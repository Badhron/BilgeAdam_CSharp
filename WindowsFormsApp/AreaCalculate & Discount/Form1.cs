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
            button1.Enabled = false;
            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Enabled = false;
            textBox1.Visible = false;
            textBox2.Enabled = false;     
            textBox2.Visible = false;
            listBox1.Visible = false;
            listBox1.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
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
                listBox1.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString().Equals("Kare")){
                textBox1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Dikdörtgen"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Ucgen"))
            {
                textBox1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Daire"))
            {
                textBox1.Enabled = true;
            }
        }

        void Kare(double kenar1)
        {
            double KareAlan = kenar1 * kenar1;
            listBox1.Items.Add("Kare Alanı : "+ KareAlan.ToString());
        }

        void Dikdörtgen(double kenar1, double kenar2)
        {
            double DikdörtgenAlan = kenar1 * kenar2;
            listBox1.Items.Add("Dikdörtgen Alanı : " + DikdörtgenAlan.ToString());
        }
        void Ucgen(double kenar1, double kenar2)
        {
            double UcgenAlan = ((kenar1 * kenar2)/2);
            listBox1.Items.Add("Üçgen Alanı : " + UcgenAlan.ToString());
        }
        void Daire(double kenar1)
        {
            double DaireAlan = (kenar1 * kenar1 * 3);
            listBox1.Items.Add("Daire Alanı : " + DaireAlan.ToString());
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Kare"))
            {
                Kare(Convert.ToDouble(textBox1.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Dikdörtgen"))
            {
                Dikdörtgen(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Ucgen"))
            {
                Ucgen(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Daire"))
            {
                Daire(Convert.ToDouble(textBox1.Text));
            }
            listBox1.Enabled = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ButtonActivate();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonActivate();
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
            else if (comboBox1.SelectedItem.ToString().Equals("Ucgen"))
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
