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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            char[] SesliHarfler = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};          
            string metin = textBox1.Text;
            int count = 0;

            for (int i=0; i < SesliHarfler.Length; i++)
            {
                for(int j=0; j < metin.Length; j++)
                {
                    if(SesliHarfler[i] == metin[j])
                    {
                        count++;
                    }
                }
            }
            // MessageBox.Show(count + " adet sesli harf var");
            label2.Text = count + " adet sesli harf var";
        }
    }
}
