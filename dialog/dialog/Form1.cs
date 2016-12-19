using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (textBox1.Text!= " ")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            textBox1.Clear();
            textBox1.Focus();
            textBox1.ForeColor  = Color.Pink;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyormusun ? ....", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyormusun ? ....", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
           
        }
    }
}
