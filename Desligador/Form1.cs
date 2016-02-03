using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligador
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int tempototal = (Convert.ToInt32(numericUpDown1.Value) * 86400) + (Convert.ToInt32(numericUpDown2.Value) * 3600) + (Convert.ToInt32(numericUpDown3.Value) * 60) + Convert.ToInt32(numericUpDown4.Value);
            Process processo = new Process();
            processo.StartInfo.FileName = "cmd";
            processo.StartInfo.Arguments = "/c shutdown /s /t " + tempototal + "";
            processo.StartInfo.UseShellExecute = false;
            processo.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process processo = new Process();
            processo.StartInfo.FileName = "cmd";
            processo.StartInfo.Arguments = "/c shutdown /a";
            processo.StartInfo.UseShellExecute = false;
            processo.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tempototal = (Convert.ToInt32(numericUpDown1.Value) * 86400) + (Convert.ToInt32(numericUpDown2.Value) * 3600) + (Convert.ToInt32(numericUpDown3.Value) * 60) + Convert.ToInt32(numericUpDown4.Value);
            Process processo = new Process();
            processo.StartInfo.FileName = "cmd";
            processo.StartInfo.Arguments = "/c shutdown /r /t " + tempototal + "";
            processo.StartInfo.UseShellExecute = false;
            processo.Start();
        }
    }
}
