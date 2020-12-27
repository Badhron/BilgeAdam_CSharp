using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Hesapla Hesapla = new Hesapla();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculate();          
        }

        void Calculate()
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);

            if (comboBox1.SelectedItem.Equals("Plus"))
            {
                double result = Hesapla.Plus(sayı1, sayı2);
                MessageBox.Show("Plus Result : "+ result.ToString());
            }
            else if (comboBox1.SelectedItem.Equals("Minus"))
            {
                double result = Hesapla.Minus(sayı1, sayı2);
                MessageBox.Show("Minus Result : " + result.ToString());
            }
            else if (comboBox1.SelectedItem.Equals("Divide"))
            {
                double result = Hesapla.Divide(sayı1, sayı2);
                MessageBox.Show("Divide Result : " + result.ToString());
            }
            else if (comboBox1.SelectedItem.Equals("Multiply"))
            {
                double result = Hesapla.Multiply(sayı1, sayı2);
                MessageBox.Show("Multiply Result : " + result.ToString());
            }
        }
    }
}
