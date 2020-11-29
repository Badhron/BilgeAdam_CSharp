using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        void Hesapla()
        {
            double fiyat, oran, tutar;

            fiyat = Convert.ToDouble(textBox1.Text);

            if (comboBox1.SelectedItem == "KADIN")
            {
                tutar = fiyat * 0.82;
            }
            else 
            {
                tutar = fiyat * 0.9;
            }
            label3.Text = tutar.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
