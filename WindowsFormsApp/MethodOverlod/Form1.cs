using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Enabled = false;
            textBox1.Visible = false;
            textBox2.Enabled = false;
            textBox2.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Kare"))
            {
                Hesapla(Convert.ToDouble(textBox1.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Dikdörtgen"))
            {
                Hesapla(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Üçgen"))
            {
                Hesapla(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToString(comboBox1.SelectedItem));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Daire"))
            {
                Hesapla(Convert.ToDouble(textBox1.Text), Convert.ToString(comboBox1.SelectedItem));
            }
            label4.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                button1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString().Equals("Kare"))
            {
                textBox1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Dikdörtgen"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Üçgen"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Daire"))
            {
                textBox1.Enabled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ButtonActivate();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonActivate();
        }

        void Hesapla(double kenar1) // Kare
        {
            double KareAlan = kenar1 * kenar1;
            label4.Text = "Karenin Alanı : " + KareAlan;
        }
        void Hesapla(double kenar1, double kenar2) // Dikdörtgen
        {
            double DikdörtgenAlan = kenar1 * kenar2;
            label4.Text = "Dikdörtgen Alanı : " + DikdörtgenAlan;
        }
        void Hesapla(double kenar1, double kenar2, String ŞekilÜçgen) // Ucgen
        {
            if (ŞekilÜçgen == comboBox1.SelectedItem.ToString())
            {
                double UcgenAlan = ((kenar1 * kenar2) / 2);
                label4.Text = "Ucgen Alanı : " + UcgenAlan;
            }
        }
        void Hesapla(double kenar1, String ŞekilDaire) // Daire
        {
            if (ŞekilDaire == comboBox1.SelectedItem.ToString())
            {
                double DaireAlan = (kenar1 * kenar1 * 3);
                label4.Text = "Daire Alanı : " + DaireAlan;
            }
        }


        void ButtonActivate()
        {
            if (comboBox1.SelectedItem.ToString().Equals("Kare"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Dikdörtgen"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    if (!String.IsNullOrEmpty(textBox2.Text))
                    {
                        button1.Enabled = true;
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Üçgen"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Daire"))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    button1.Enabled = true;
                }
            }
        }
    }
}
