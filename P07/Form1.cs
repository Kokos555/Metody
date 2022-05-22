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

namespace P07
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
            if (Retezec.JeAlfanum(slovo, out int male_pismena, out int cifry,out int jine_znaky))
            {
                MessageBox.Show(string.Format("Veta ({0}), neobsahuje zadne alfanumencické znaky: Pocet malých písmen = {1}, počet čísel = {2} a počet čísel {3} prvočíslo",slovo,male_pismena,cifry,Matika.Prvocislo(cifry) ? "je" : "není"));
            }else
            {
                MessageBox.Show(string.Format("Veta ({0}), obsahuje alfanumerické znaky, a to přesně {1}", slovo, jine_znaky));
            }
        }
    }
}
