using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace XenonautsEditor
{
    public static class SaveDataEditor
    {
        public struct SoldierData
        {
            public byte tu, hp, str, acc, rex, bra;
            public string name;
            public int nameStartOffset;
        }

        public class SoldierDataOffset
        {
            public SoldierDataOffset(int offset, SoldierData data)
            {
                this.offset = offset;
                this.data = data;
                this.name = data.name;
            }

            public int offset;
            public SoldierData data;
            public string name { get; set; }
        }

        public static byte[] ReadData(string path)
        {
            using (var file = File.OpenRead(path))
            {
                var buffer = new byte[file.Length];
                file.Read(buffer, 0, (int)file.Length);
                return buffer;
            } 
        }

        public static SoldierDataOffset[] ParseSoldierData(byte[] data)
        {
            List<SoldierDataOffset> soldiers = new List<SoldierDataOffset>();
            int offset = 0;
            byte[] dataStartFlag = new byte[] { 0x53, 0x6F, 0x6C, 0x64, 0x69, 0x65, 0x72, 0x46, 0x6C, 0x61, 0x67, 0x73 };
            while (offset <= data.Length - 8)
            {
                var a = data.Skip(offset).Take(dataStartFlag.Length).ToArray();
                if (a.SequenceEqual(dataStartFlag))
                {
                    var natLenght = data[offset + dataStartFlag.Length + 1];
                    SoldierData sd = new SoldierData();
                    sd.tu = data[offset + dataStartFlag.Length + 5 + natLenght];
                    sd.hp = data[offset + dataStartFlag.Length + 5 + natLenght + 4];
                    sd.str = data[offset + dataStartFlag.Length + 5 + natLenght + 8];
                    sd.acc = data[offset + dataStartFlag.Length + 5 + natLenght + 12];
                    sd.rex = data[offset + dataStartFlag.Length + 5 + natLenght + 16];
                    sd.bra = data[offset + dataStartFlag.Length + 5 + natLenght + 20];

                    int nameStartOffset = -17;
                    var nameLenghtMarker = new byte[] { 0x0, 0x0, 0x0 };
                    while (true)
                    {

                        if (data.Skip(offset + nameStartOffset).Take(3).ToArray().SequenceEqual(nameLenghtMarker))
                        {
                            int nameLenght = data[offset + nameStartOffset - 1];
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < nameLenght; i++)
                            {
                                sb.Append((char)data[offset + nameStartOffset + 3 + i]);
                            }
                            sd.name = sb.ToString();
                            sd.nameStartOffset = offset + nameStartOffset - 1;
                            nameStartOffset = -17;
                            break;
                        }
                        else
                        {
                            nameStartOffset--;
                        }
                    }

                    SoldierDataOffset sdo = new SoldierDataOffset((offset + dataStartFlag.Length + 5 + natLenght), sd);
                    soldiers.Add(sdo);
                }
                offset++;
            }

            return soldiers.ToArray();
        }

        public static SoldierDataOffset[] ParseSoldierDataCommunity(byte[] data)
        {
            List<SoldierDataOffset> soldiers = new List<SoldierDataOffset>();
            int offset = 0;
            byte[] dataStartFlag = new byte[] { 0x4D, 0x41, 0x52, 0x4B, 0x07, 0x00, 0x00, 0x00,
                0x53, 0x6F, 0x6C, 0x64, 0x69, 0x65, 0x72 };
            while (offset <= data.Length - 8)
            {
                var a = data.Skip(offset).Take(dataStartFlag.Length).ToArray();
                if (a.SequenceEqual(dataStartFlag))
                {
                    var natLenght = data[offset + dataStartFlag.Length + 4];
                    SoldierData sd = new SoldierData();

                    int nameStartOffset = offset + dataStartFlag.Length + natLenght + 8;
                    int nameLenght = data[offset + dataStartFlag.Length + natLenght + 8];
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < nameLenght; i++)
                    {
                        sb.Append((char)data[nameStartOffset + 4 + i]);
                    }
                    sd.name = sb.ToString();
                    sd.nameStartOffset = nameStartOffset - 1;

                    int natLenght2 = data[nameStartOffset + 4 + nameLenght];
                    int natLenght3 = data[nameStartOffset + 4 + nameLenght + natLenght2 + 4 + 4];
                    int statsStartOffset = nameStartOffset + 4 + nameLenght + natLenght2 + 4 + 4 + natLenght3 + 4;

                    sd.tu = data[statsStartOffset];
                    sd.hp = data[statsStartOffset + 4];
                    sd.str = data[statsStartOffset + 8];
                    sd.acc = data[statsStartOffset + 12];
                    sd.rex = data[statsStartOffset + 16];
                    sd.bra = data[statsStartOffset + 20];


                    SoldierDataOffset sdo = new SoldierDataOffset((statsStartOffset), sd);
                    soldiers.Add(sdo);
                }
                offset++;
            }

            return soldiers.ToArray();
        }

        public static void OverwriteSoldierData(SoldierDataOffset[] newData, byte[] oldData)
        {
            foreach(var s in newData)
            {
                oldData[s.offset] = s.data.tu;
                oldData[s.offset + 4] = s.data.hp;
                oldData[s.offset + 8] = s.data.str;
                oldData[s.offset + 12] = s.data.acc;
                oldData[s.offset + 16] = s.data.rex;
                oldData[s.offset + 20] = s.data.bra;

                for (int i = 0; i < s.data.name.Length || i < oldData[s.data.nameStartOffset]; i++)
                {
                    if (i < s.data.name.Length)
                        oldData[s.data.nameStartOffset + i + 4] = Convert.ToByte(s.data.name[i]);
                    else
                        oldData[s.data.nameStartOffset + i + 4] = Convert.ToByte(' ');
                }
                if (oldData[s.data.nameStartOffset] < s.data.name.Length)
                    oldData[s.data.nameStartOffset] = Convert.ToByte(s.data.name.Length);
            }

            using (var file = File.Create("ModifiedSave.sav"))
            {
                file.Write(oldData, 0, oldData.Length);
            }

        }

        public static void OverwriteSoldierDataCommunity(SoldierDataOffset[] newData, byte[] oldData, string path = "ModifiedSave.sav")
        {
            var soldierCounter = 0;
            foreach (var s in newData)
            {
                oldData[s.offset] = s.data.tu;
                oldData[s.offset + 4] = s.data.hp;
                oldData[s.offset + 8] = s.data.str;
                oldData[s.offset + 12] = s.data.acc;
                oldData[s.offset + 16] = s.data.rex;
                oldData[s.offset + 20] = s.data.bra;

                var dataList = new List<byte>(oldData);
                dataList.RemoveRange(s.data.nameStartOffset + 5, oldData[s.data.nameStartOffset + 1]);

                for (int i = 0; i < s.data.name.Length; i++)
                {
                    dataList.Insert(s.data.nameStartOffset + 5 + i, Convert.ToByte(s.data.name[i]));
                }

                dataList[s.data.nameStartOffset + 1] = Convert.ToByte(s.data.name.Length);

                    for (int i = soldierCounter + 1; i < newData.Length; i++)
                    {
                        newData[i].offset += dataList[s.data.nameStartOffset + 1] - oldData[s.data.nameStartOffset + 1];
                        newData[i].data.nameStartOffset += dataList[s.data.nameStartOffset + 1] - oldData[s.data.nameStartOffset + 1];
                    }

                oldData = dataList.ToArray();

                soldierCounter++;


            }

            using (var file = File.Create(path))
            {
                file.Write(oldData, 0, oldData.Length);
            }

        }
    }   
}
