using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arama_ornegi_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text;
            bool bulundu = false;
            int sayac = 0;

            for (int i =0; i < 20; i++)
            {
                string kisi = Convert.ToString(lbKisi.Items[i]);
                if (kisi == lbKisi.Items[i].ToString()) 
                {
                    bulundu = true;
                    sayac++;
                }
            }
            if (bulundu)
            {
                lblSonuc.Text = "Aranan kişiden" + sayac+ "tane var";
            }
            else
            {
                lblSonuc.Text = "Aranan kişi bulunmadı";
            }
        }
    }
}
