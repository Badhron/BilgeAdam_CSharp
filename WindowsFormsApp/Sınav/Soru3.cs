using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Soru3 : Form
    {
        public Soru3()
        {
            InitializeComponent();
        }

        private void Soru3_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string isim = Convert.ToString(textBox2.Text);
            string soyisim = Convert.ToString(textBox3.Text);
            string ünvan = comboBox1.SelectedItem.ToString();
            double maas = Convert.ToDouble(textBox1.Text);

            double prim = 0;

            if (ünvan.Equals("işçi"))
            {
                prim = maas * 0.10;
            }
            else if(ünvan.Equals("müdür yardımcısı")){
                prim = maas * 0.20;
            }
            else if (ünvan.Equals("müdür"))
            {
                prim = maas * 0.35;
            }


            String path = "C:/Users/User/Desktop/Prim.txt";
            FileStream yaz = new FileStream(@path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(yaz);
            sw.WriteLine(" ad : "+ isim +" soyad : "+ soyisim + " ünvan : " + ünvan + " maaş : " + maas + " prim : " + prim );
            sw.Flush();
            sw.Close();
            yaz.Close();
        }
    }
}
