using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_otobüs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 1;

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if ((i ==12||j != 2)&&(i!=6||j<2))
                    {
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = sayac + " ";
                        btn.BackColor = Color.Aqua;
                        btn.Left = (btn.Width * j) + 150;
                        btn.Top = (btn.Height * i) + 20;
                        sayac++;
                        this.Controls.Add(btn);
                    }
                    




                }
            }
        }
    }
}

