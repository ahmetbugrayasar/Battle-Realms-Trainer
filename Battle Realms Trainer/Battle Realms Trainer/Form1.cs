using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
namespace Battle_Realms_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();
        private void Battle_Realms_Trainer_Load(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   while(true)
            {
                int pID = m.GetProcIdFromName("Battle_Realms_EF"); //Get ProcID from game
                bool openProc = false; //Is process open?
                if (pID > 0) { openProc = m.OpenProcess(pID); } //Try opening process if proc ID is greaten than 1
                if (openProc) //If process is open, follow code
                {
                    while (CheckboxRice.Checked) { m.WriteMemory("0x0B7B1860", "int", "123423"); }
                    while(!CheckboxRice.Checked) { m.WriteMemory("0x0B7B1860", "int", "0"); }

                }
            }
            
        }
    }
}
