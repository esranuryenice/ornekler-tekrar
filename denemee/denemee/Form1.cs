using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_domates_Click(object sender, EventArgs e)
        {

            double sonuc = 1;
            double sayi1, sayi2=2.5;
            double hesapla;
            txt_fiyat.Text = "2,5";
            sayi2 = Convert.ToDouble(txt_fiyat.Text);
            txt_adet.Visible = false;
            sayi1 = Convert.ToDouble(txt_kilo.Text);
            if (sayi1>=1)
            {
                sonuc = sayi1 * sayi2;
            }
            
            MessageBox.Show(sonuc.ToString());
            
        }
    }
}
