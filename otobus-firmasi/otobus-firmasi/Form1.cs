using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobus_firmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_otobusturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_otobusturu.SelectedItem.ToString() == "Travego")
            {
                PanelTravego.Visible = true;
                PanelSetra.Visible = false;
            }
            else
            {
                PanelSetra.Visible = true;
                PanelTravego.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelTravego.Visible = false;
            PanelSetra.Visible = false;
            #region koltuklarıoluşturmatravego

            int counter = 1;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 10) && (i != 4 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += ButtonClick;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + " ";
                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        PanelTravego.Controls.Add(btn);
                        counter++;
                    }



                }
            }
            #endregion
            #region koltuklarıoluşturmasetra


            counter = 1;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 10) && (i != 6 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += ButtonClick;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + "";
                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        PanelSetra.Controls.Add(btn);
                        counter++;

                    }
                }
            }
            #endregion

        }
        string[] travegoyolcularIsim = new string[60];
        string[] travegoyolcularCinsiyet = new string[60];
        string[] setrayolcularIsim = new string[60];
        string[] setrayolcularCinsiyet = new string[60];

        private void ButtonClick(object sender, EventArgs e)
        {
            Button secilenkoltuk = new Button();
            LblKoltukNo.Text = secilenkoltuk.Text;
            LblOtobusturu.Text = comboBox_otobusturu.SelectedItem.ToString();
            RdnBtnErkek.Visible = true;
            RdnBtnKadın.Visible = false;
            if (LblOtobusturu.Text == "Travego")
            {
                string yolcu = travegoyolcularIsim[int.Parse(secilenkoltuk.Text) - 1];
                if (yolcu != " ")
                {
                    TxtAdSoyad.Text = yolcu;
                    string oncekiveyasonrakicinsiyet;
                    int koltukno = int.Parse(LblKoltukNo.Text);
                    if (koltukno % 2 == 0)
                    {
                        int bakilacakkoltuk = int.Parse(LblKoltukNo.Text) - 1;
                        oncekiveyasonrakicinsiyet = travegoyolcularCinsiyet[bakilacakkoltuk - 1];
                        if (oncekiveyasonrakicinsiyet == "Erkek")
                        {
                            RdnBtnKadın.Checked = false;
                        }
                        else if (oncekiveyasonrakicinsiyet == "Kadın")
                        {
                            RdnBtnErkek.Checked = false;
                        }
                        else
                        {
                            RdnBtnErkek.Checked = true;
                            RdnBtnKadın.Checked = true;
                        }

                    }
                }


                else
                {

                    int bakilacakkoltuk = int.Parse(LblKoltukNo.Text) + 1;
                    string oncekiveyasonrakicinsiyet = setrayolcularCinsiyet[bakilacakkoltuk - 1];
                    if (oncekiveyasonrakicinsiyet == "Erkek")
                    {
                        RdnBtnKadın.Checked = false;
                    }
                    else if (oncekiveyasonrakicinsiyet == "Kadın")
                    {
                        RdnBtnErkek.Checked = false;
                    }
                    else
                    {
                        RdnBtnErkek.Checked = true;
                        RdnBtnKadın.Checked = true;
                    }

                }
                string kendicinsiyeti = setrayolcularCinsiyet[int.Parse(secilenkoltuk.Text) - 1];
                if (kendicinsiyeti == "Erkek")
                {
                    RdnBtnErkek.Checked = true;
                    RdnBtnErkek.BackColor = Color.Blue;

                }
                else if (kendicinsiyeti == "Kadın")
                {
                    RdnBtnKadın.Checked = true;
                    RdnBtnKadın.BackColor = Color.Pink;
                }

            }
            else
            {


                string yolcu = setrayolcularIsim[int.Parse(secilenkoltuk.Text) - 1];
                if (yolcu != " ")
                {
                    TxtAdSoyad.Text = yolcu;
                    string oncekiveyasonrakicinsiyet;
                    int koltukno = int.Parse(LblKoltukNo.Text);
                    if (koltukno % 2 == 0)
                    {
                        int bakilacakkoltuk = int.Parse(LblKoltukNo.Text) - 1;
                        oncekiveyasonrakicinsiyet = setrayolcularCinsiyet[bakilacakkoltuk - 1];
                        if (oncekiveyasonrakicinsiyet == "Erkek")
                        {
                            RdnBtnKadın.Checked = false;
                        }
                        else if (oncekiveyasonrakicinsiyet == "Kadın")
                        {
                            RdnBtnErkek.Checked = false;
                        }
                        else
                        {
                            RdnBtnErkek.Checked = true;
                            RdnBtnKadın.Checked = true;
                        }

                    }
                }


                else
                {

                    int bakilacakkoltuk = int.Parse(LblKoltukNo.Text) + 1;
                    string oncekiveyasonrakicinsiyet = setrayolcularCinsiyet[bakilacakkoltuk - 1];
                    if (oncekiveyasonrakicinsiyet == "Erkek")
                    {
                        RdnBtnKadın.Checked = false;
                    }
                    else if (oncekiveyasonrakicinsiyet == "Kadın")
                    {
                        RdnBtnErkek.Checked = false;
                    }
                    else
                    {
                        RdnBtnErkek.Checked = true;
                        RdnBtnKadın.Checked = true;
                    }

                }
                string kendicinsiyeti = setrayolcularCinsiyet[int.Parse(secilenkoltuk.Text) - 1];
                if (kendicinsiyeti == "Erkek")
                {
                    RdnBtnErkek.Checked = true;
                    RdnBtnErkek.BackColor = Color.Blue;

                }
                else if (kendicinsiyeti == "Kadın")
                {
                    RdnBtnKadın.Checked = true;
                    RdnBtnKadın.BackColor = Color.Pink;


                }



            }
        }
    }
}
