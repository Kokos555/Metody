using PosloupnostUtil;
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
                        double obsah_kvadru = Posloupnost.Objem(a, b, c, out double telesova);
                        MessageBox.Show(string.Format("Kvadr o velikosti stran {0}, {1} a {2} má objem {3} a telesovou uhlopricku {4:F2}", a, b, c, obsah_kvadru, telesova));
                    }else
                    {
                        double obsah_obdelniku = Posloupnost.Obsah(a, b, out double uhlopricka);
                        MessageBox.Show(string.Format("Obdelnik o velikosti strany {0} a {1} má obsah {2} a uhlopricku {3:F2}", a, b, obsah_obdelniku, uhlopricka));
                    }
                }else
                {
                    double obsah_ctverce = Posloupnost.Obsah(a, out double uhlopricka);
                    MessageBox.Show(string.Format("Čtverec o velikosti strany {0} má obsah {1} a uhlopricku {2:F2}", a, obsah_ctverce, uhlopricka));
                    double objem_krychle = Posloupnost.Objem(a, out double telesova_uhlopricka);
                    MessageBox.Show(string.Format("Krychle o rozměru {0} má objem {1} a telesovou uhlopricku {2:F2}", a, objem_krychle, telesova_uhlopricka));
                }

            }
        }
    }
}
