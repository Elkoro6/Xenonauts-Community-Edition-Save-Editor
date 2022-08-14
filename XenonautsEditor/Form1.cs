using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XenonautsEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int selectedSoldier;
        public SaveDataEditor.SoldierDataOffset[] soldiers;
        public BindingSource bs = new BindingSource();
        byte[] oldData;





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Xenonauts";
            openFileDialog1.ShowDialog();

            if(openFileDialog1.FileName.EndsWith("sav"))
            {
                soldiers = SaveDataEditor.ParseSoldierDataCommunity(SaveDataEditor.ReadData(openFileDialog1.FileName));
                oldData = SaveDataEditor.ReadData(openFileDialog1.FileName);
                selectedSoldier = 0;
                UpdateStatsBoxes(soldiers[selectedSoldier].data);
                PopulateSoldierList();
                EnableControls();
            }
        }
        private void EnableControls()
        {
            NameBox.Enabled = true;
            TuBox.Enabled = true;
            HpBox.Enabled = true;
            StrBox.Enabled = true;
            AccBox.Enabled = true;
            RefBox.Enabled = true;
            BraBox.Enabled = true;
        }

        private void PopulateSoldierList()
        {
            bs.DataSource = soldiers;
            SoldierList.DataSource = bs;
            SoldierList.DisplayMember = "name";

        }
        private void UpdateStatsBoxes(SaveDataEditor.SoldierData stats)
        {
            NameBox.Text = stats.name;
            TuBox.Value = stats.tu;
            HpBox.Value = stats.hp;
            StrBox.Value = stats.str;
            AccBox.Value = stats.acc;
            RefBox.Value = stats.rex;
            BraBox.Value = stats.bra;
        }

        private void UpdateSoldierData()
        {
            soldiers[selectedSoldier].data.name = NameBox.Text;
            soldiers[selectedSoldier].name = NameBox.Text;
            soldiers[selectedSoldier].data.tu = Convert.ToByte(TuBox.Value);
            soldiers[selectedSoldier].data.hp = Convert.ToByte(HpBox.Value);
            soldiers[selectedSoldier].data.str = Convert.ToByte(StrBox.Value);
            soldiers[selectedSoldier].data.acc = Convert.ToByte(AccBox.Value);
            soldiers[selectedSoldier].data.rex = Convert.ToByte(RefBox.Value);
            soldiers[selectedSoldier].data.bra = Convert.ToByte(BraBox.Value);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();
            if(saveDialog.FileName.EndsWith(".sav"))
              SaveDataEditor.OverwriteSoldierDataCommunity(soldiers, oldData, saveDialog.FileName);
        }

        private void SoldierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSoldier = SoldierList.SelectedIndex;
            
            UpdateStatsBoxes(soldiers[selectedSoldier].data);
            PopulateSoldierList();
        }

        private void TuBox_ValueChanged(object sender, EventArgs e)
        {
            UpdateSoldierData();
            bs.ResetBindings(false);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TuBox_Enter(object sender, EventArgs e)
        {
            NumericUpDown box = (NumericUpDown)sender;
            box.Select(0, box.Text.Length);
        }
    }
}
