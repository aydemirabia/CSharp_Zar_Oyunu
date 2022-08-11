using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int toplamBen = 0;
        int toplamRandom = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 7);
            int b = rnd.Next(1, 7);
            lblBirinciZar.Text = a.ToString();
            lblIkinciZar.Text = b.ToString();

            int toplam = a + b;
            lblToplam.Text = toplam.ToString();
            
            toplamBen += a + b;
            lbltoplamBen.Text = toplamBen.ToString();
            if (toplamBen >= 100)
            {
                MessageBox.Show("Kazanan Siz Oldunuz! Tebrikler :) ");
            }

        }

        private void btnRandomBasla_Click(object sender, EventArgs e)
        {
            int m = rnd.Next(1, 7);
            int n = rnd.Next(1, 7);

            lblRandomIlkZar.Text = m.ToString();
            lblRandomIkınciZar.Text = n.ToString();

            int toplam = m + n;
            lblRandomToplam.Text = toplam.ToString();

            toplamRandom += m + n;
            lblToplamRandom.Text = toplamRandom.ToString();
            if (toplamRandom >= 100)
            {
                MessageBox.Show("Kazanan Random oldu. Kaybettiniz!");
            }
            
        }
    }
}
