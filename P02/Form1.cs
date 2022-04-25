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

        private int[] Generovani(int pocet, int dolni_mez = 1, int horni_mez = 100)
        {
            Random nh = new Random();
            int[] pole = new int[pocet];
            for (int i = 0; i < pocet; i++) {
                int x = nh.Next(dolni_mez, horni_mez);
                pole[i] = x;
            }
            return pole;
        }


        private void Zobrazit(ListBox cisla, int[] pole)
        {
            cisla.Items.Clear();
            for (int i = 0; i < pole.Length; i++) {
                cisla.Items.Add(pole[i]);
            }
        }

        private int SoucetAPocet(out int pocet, int[] pole)
        {
            pocet = 0;
            int soucet = 0;
            foreach (int cisla in pole)
            {
                if (cisla % 2 == 0)
                {
                    soucet += cisla;
                } else
                {
                    pocet++;
                }
            }
            return soucet;
        }
        private bool Roustouci(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] <= pole[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void Vymena(int[] pole)
        {
            int max = pole.Max();
            int poradi = Array.IndexOf(pole, max);
            int posledni_radek_pole = pole.Length - 1;
            pole[poradi] = pole[posledni_radek_pole];
            pole[posledni_radek_pole] = max;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole;
            int pocet = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text != "" && textBox3.Text != "") { 
                int horni_mez = Convert.ToInt32(textBox3.Text);
                int dolni_mez = Convert.ToInt32(textBox2.Text);
                pole = Generovani(pocet, dolni_mez, horni_mez);
            }else
            {
                pole = Generovani(pocet);
            }
            Zobrazit(listBox1, pole);
            int pocet2;
            int soucet_sudych = SoucetAPocet(out pocet2, pole);
            MessageBox.Show(string.Format("Součet sudých čísel je {0} a počet lichých čísel je {1}", soucet_sudych, pocet2));
            MessageBox.Show(string.Format("Toto generovani cisel {0} roustoucí.", Roustouci(pole) ? "je" : "není"));
            Vymena(pole);
            Zobrazit(listBox2, pole);

        }
    }
}
