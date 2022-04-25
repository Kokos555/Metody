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

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int a2 = Convert.ToInt32(textBox2.Text);
            int n = Convert.ToInt32(textBox3.Text);
            int vysledek = Posloupnost.SoucetArPosl(ref a1, a2, n, out int diference);
            MessageBox.Show(string.Format("{0} posledni prvek je {1} a diference posloupnosti je {2}",vysledek ,a1,diference));
        }
    }
}
