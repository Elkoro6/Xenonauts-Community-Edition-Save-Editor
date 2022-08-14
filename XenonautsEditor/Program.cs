using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XenonautsEditor
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            SaveDataEditor.SoldierDataOffset[] soldiers;
            byte[] oldData;

            Application.EnableVisualStyles();
            Application.Run(new Form1());

        }
    }
}
