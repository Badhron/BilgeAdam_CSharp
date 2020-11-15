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
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            checkBox1.Visible = true;
            comboBox1.Visible = false;
            listBox1.Visible = false;
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            checkBox1.Visible = false;
            comboBox1.Visible = true;

            if (checkBox1.Checked = true)
            {
                button1.Visible = false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;

            if (checkBox1.Checked = true)
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                Double sayı1 = Convert.ToInt32(textBox1.Text);
                Double sayı2 = Convert.ToInt32(textBox2.Text);

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        double Toplama = sayı1 + sayı2;
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show(Convert.ToString(Toplama), "Result");
                        listBox1.Items.Add("Toplama işlemi Sonucu : " + Toplama);
                        break;
                    case 1:
                        double çıkarma = sayı1 - sayı2;
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show(Convert.ToString(çıkarma), "Result");
                        listBox1.Items.Add("Çıkarma işlemi Sonucu : " + çıkarma);
                        break;
                    case 2:
                        double çarpma = sayı1 * sayı2;
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show(Convert.ToString(çarpma), "Result");
                        listBox1.Items.Add("Çarpma işlemi Sonucu : " + çarpma);
                        break;
                    case 3:
                        double bölme = sayı1 / sayı2;
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show(Convert.ToString(bölme), "Result");
                        listBox1.Items.Add("Bölme işlemi Sonucu : " + bölme);
                        break;
                }
            }
            else
            {
                MessageBox.Show("İşlem Aktif Değil");
            }
            listBox1.Visible = true;

        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Label2_Click(object sender, EventArgs e)
        {
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

