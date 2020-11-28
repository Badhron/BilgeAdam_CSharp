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

        private void Form1_Load(object sender, EventArgs e)
        {
            //butonlar ve liste başlangıçta gözükmeyecek
            listBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            //Butonlar aktif değil
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                //textbox1 e yazınca butonlar görünür hale gelecek
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    //textbox1 ve textbox2 yazınca butonlar işlevsel hale gelecek
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int car1 = Convert.ToInt32(textBox1.Text);
            int car2 = Convert.ToInt32(textBox2.Text);

            double Çarpma = Carp(car1, car2);

            MessageBox.Show(Çarpma.ToString());
            listBox1.Items.Add(Çarpma);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Visible = true;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Double top1 = Convert.ToInt32(textBox1.Text);
            Double top2 = Convert.ToInt32(textBox2.Text);

            double toplam = Topla(top1, top2);

            MessageBox.Show(toplam.ToString());
            listBox1.Items.Add(toplam);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Double bol1 = Convert.ToInt32(textBox1.Text);
            Double bol2 = Convert.ToInt32(textBox2.Text);

            double bölme = Bol(bol1, bol2);

            MessageBox.Show(bölme.ToString());
            listBox1.Items.Add(bölme);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int cık1 = Convert.ToInt32(textBox1.Text);
            int cık2 = Convert.ToInt32(textBox2.Text);

            double çıkartma = Çıkar(cık1, cık2);

            MessageBox.Show(çıkartma.ToString());
            listBox1.Items.Add(çıkartma);
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Visible = true;
        }

        Double Topla(Double sayı1, Double sayı2)
        {
            return sayı1 + sayı2;
        }

        Double Çıkar(Double sayı1, Double sayı2)
        {
            return sayı1 - sayı2;
        }

        Double Carp(Double sayı1, Double sayı2)
        {
            return sayı1 * sayı2;
        }

        Double Bol(Double sayı1, Double sayı2)
        {
            return sayı1 / sayı2;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
