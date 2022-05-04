using PoleUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random value = new Random();
            int N = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(textBox2.Text);
            int[] pole;
            int dol = -100;
            int hor = 101;
            pole = Pole.Generovani(N, dol, hor);
            Pole.Zobrazit(listBox1, pole);
            pole = Pole.VynulovaniAMocnina(pole, x);
            Pole.Zobrazit(listBox2, pole);
        }
    }
}
