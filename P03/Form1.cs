using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private double Obsah(double a, out double uhlopricka_ctverce)
        {
            double obsah_ctverce = a * a;
            uhlopricka_ctverce = a * Math.Sqrt(2);
            return obsah_ctverce;
        }

        static private double Obsah(double a, double b, out double uhlopricka_obdelniku)
        {
            double obsah_obdelniku = a * b;
            uhlopricka_obdelniku = Math.Sqrt((a * a) + (b * b));
            return obsah_obdelniku;
        }

        static private double Objem(double a, out double telesova_uhlopricka)
        {
            double objem_krychle = a * a * a;
            telesova_uhlopricka = a * Math.Sqrt(3);
            return objem_krychle;
        }
        static private double Objem(double a, double b, double c, out double telesova_uhlopricka_kvadru)
        {
            double objem = a * b * c;
            telesova_uhlopricka_kvadru = Math.Sqrt((a * a) + (b * b) + (c * c));
            return objem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b, c;
            if (textBox1.Text != string.Empty)
            {
                a = Convert.ToInt32(textBox1.Text);
                if (textBox2.Text != string.Empty)
                {
                    b = Convert.ToInt32(textBox2.Text);
                    if (textBox3.Text != string.Empty)
                    {
                        c = Convert.ToInt32(textBox3.Text);
                        double obsah_kvadru = Objem(a, b, c, out double telesova);
                        MessageBox.Show(string.Format("Kvadr o velikosti stran {0}, {1} a {2} má objem {3} a telesovou uhlopricku {4:F2}", a, b, c, obsah_kvadru, telesova));
                    }else
                    {
                        double obsah_obdelniku = Obsah(a, b, out double uhlopricka);
                        MessageBox.Show(string.Format("Obdelnik o velikosti strany {0} a {1} má obsah {2} a uhlopricku {3:F2}", a, b, obsah_obdelniku, uhlopricka));
                    }
                }else
                {
                    double obsah_ctverce = Obsah(a, out double uhlopricka);
                    MessageBox.Show(string.Format("Čtverec o velikosti strany {0} má obsah {1} a uhlopricku {2:F2}", a, obsah_ctverce, uhlopricka));
                    double objem_krychle = Objem(a, out double telesova_uhlopricka);
                    MessageBox.Show(string.Format("Krychle o rozměru {0} má objem {1} a telesovou uhlopricku {2:F2}", a, objem_krychle, telesova_uhlopricka));
                }

            }
        }
    }
}
