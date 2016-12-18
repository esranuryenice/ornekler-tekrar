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


        private void Form1_Load(object sender, EventArgs e)
        {
            List<double> tutar = new List<double>();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button secilensebze = sender as Button;
            txt_toplam.Text = secilensebze.Text;


           
            
            


        }

        private void btn_domates_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "2.5 TL";
            double sonuc = 0, sayi1 = 2.5, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2>=1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString()+ " TL ";

        }

        private void btn_biber_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "3 TL";
            double sonuc = 0, sayi1 = 3, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2 >= 1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";

        }

        private void btn_patlican_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "2.5 TL";
            double sonuc = 0, sayi1 = 2.5, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2 >= 1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";

        }

        private void btn_dereotu_Click(object sender, EventArgs e)
        {
            txt_kilo.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "0.50 TL";
            double sonuc = 0, sayi1 = 0.50, sayi2;
            sayi2 = Convert.ToDouble(txt_adet.Text);
            if (sayi2 <= 50)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";

        }

        private void btn_maydonoz_Click(object sender, EventArgs e)
        {
            txt_kilo.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "0.50 TL";
            double sonuc = 0, sayi1 = 0.50, sayi2;
            sayi2 = Convert.ToDouble(txt_adet.Text);
            if (sayi2 <= 50)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";
        }

        private void btn_patates_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "2.5 TL";
            double sonuc = 0, sayi1 = 2.5, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2 >= 1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";
        }

        private void btn_sogan_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "2.5 TL";
            double sonuc = 0, sayi1 = 2.5, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2 >= 1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";
        }

        private void btn_brokoli_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "2.5 TL";
            double sonuc = 0, sayi1 = 2.5, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2 >= 1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";
        }

        private void btn_karnabahar_Click(object sender, EventArgs e)
        {
            txt_adet.Visible = false;
            txt_gram.Visible = false;
            txt_fiyat.Text = "2.5 TL";
            double sonuc = 0, sayi1 = 2.5, sayi2;
            sayi2 = Convert.ToDouble(txt_kilo.Text);
            if (sayi2 >= 1)
            {
                sonuc = sayi1 * sayi2;
                txt_toplam.Text = sonuc.ToString();
            }
            txt_toplam.Text = sonuc.ToString() + " TL ";
        }
    }
}
