using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace AC2
{
    public partial class Form1 : Form
    {
        Mem xxx = new Mem();
        public static string balas = "ac_client.exe+0x0016F338,8,F8,140";
        public static string vida = "ac_client.exe+0x0016F338,8,2C,EC";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PID = xxx.GetProcIdFromName("ac_client");
            if (PID > 0)
            {
                xxx.OpenProcess(PID);
                MessageBox.Show("Encontrar processo, " + PID.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread balass = new Thread(F);
            Thread vidaa = new Thread(G);
            balass.Start();
            vidaa.Start();

        }
        private void F()
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    xxx.WriteMemory(balas, "int", "69696969");
                    Thread.Sleep(5);
                }
            }   Thread.Sleep(10);

        }
        private void G()
        {
            while (true)
            {
                if (checkBox2.Checked)
                {
                    xxx.WriteMemory(vida, "int", "69696969");
                    Thread.Sleep(5);
                }
            }
            Thread.Sleep(10);

        }

    }
}
