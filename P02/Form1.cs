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

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole;
            int pocet = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text != "" && textBox3.Text != "") { 
                int horni_mez = Convert.ToInt32(textBox3.Text);
                int dolni_mez = Convert.ToInt32(textBox2.Text);
                pole = Pole.Generovani(pocet, dolni_mez, horni_mez);
            }else
            {
                pole = Pole.Generovani(pocet);
            }
            Pole.Zobrazit(listBox1, pole);
            int soucet_sudych = Pole.SoucetAPocet(out int pocet2, pole);
            MessageBox.Show(string.Format("Součet sudých čísel je {0} a počet lichých čísel je {1}", soucet_sudych, pocet2));
            MessageBox.Show(string.Format("Toto generovani cisel {0} roustoucí.", Pole.Roustouci(pole) ? "je" : "není"));
            Pole.Vymena(pole);
            Pole.Zobrazit(listBox2, pole);

        }
    }
}
