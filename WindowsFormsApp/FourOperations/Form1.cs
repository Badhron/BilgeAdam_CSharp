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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Double sayı1 = Convert.ToInt32(textBox1.Text);
            Double sayı2 = Convert.ToInt32(textBox2.Text);
            double Toplam = sayı1 + sayı2;
            MessageBox.Show(Convert.ToString(Toplam), "Result");

            textBox1.Clear();
            textBox2.Clear();        
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Double sayı1 = Convert.ToInt32(textBox1.Text);
            Double sayı2 = Convert.ToInt32(textBox2.Text);
            double Toplam = sayı1 - sayı2;
            MessageBox.Show(Convert.ToString(Toplam), "Result");

            textBox1.Clear();
            textBox2.Clear();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Double sayı1 = Convert.ToInt32(textBox1.Text);
            Double sayı2 = Convert.ToInt32(textBox2.Text);
            double Toplam = sayı1 * sayı2;
            MessageBox.Show(Convert.ToString(Toplam), "Result");

            textBox1.Clear();
            textBox2.Clear();
        }
        private void Button4_Click(object sender, EventArgs e)
        { 
                Double sayı1 = Convert.ToInt32(textBox1.Text);
                Double sayı2 = Convert.ToInt32(textBox2.Text);
                double Toplam = sayı1 / sayı2;
                MessageBox.Show(Convert.ToString(Toplam), "Result");

                textBox1.Clear();
                textBox2.Clear();               
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Label2_Click(object sender, EventArgs e)
        {
        }
    }
}
