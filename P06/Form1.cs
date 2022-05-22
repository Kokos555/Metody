using RetezecUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string slovo = textBox1.Text;
            while (slovo.Contains("  "))
            {
                slovo = slovo.Replace("  ", " ");
            }
            string[] slova = slovo.Split(' ');
            if (Retezec.ObsahujeSlovo(slova,out string nejdelsi_slovo, out string nejkratsi_slovo))
            {
                MessageBox.Show(String.Format("Věta ({0}) obsahuje slova, nejdelsi slovo je ({1}), nejkratsi slovo je ({2})", slovo, nejdelsi_slovo, nejkratsi_slovo));
                Retezec.Zobraz(listBox1, slova);
            }
        }
    }
}
