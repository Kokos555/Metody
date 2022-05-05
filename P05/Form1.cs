using MatematikaUtil;
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

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Trim();
            if (Retezec.Obsahuje(text, out int p, out int s))
            {
                label1.Text = string.Format("Veta ({0}) obsahuje cislice ve slově, pocet vsech cifer je {1} a soucet vsech lichych cifer je {2}.", text, p, s);
                label2.Text = string.Format("Cislo {0} {1} prvocislo", s, Matika.Prvocislo(s) ? "je" : "neni");
            }
            else
            {
                label1.Text = string.Format("Veta ({0}) neobsahuje cislice ve slově.", text);
            }

        }
    }
}
