using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Soru1 : Form
    {
        public Soru1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Azalan_Click(object sender, EventArgs e) // Hesapla
        {
            if (comboBox1.SelectedItem.Equals("Azalan"))
            {
                azalan();
            }
            else
            {
                artan();
            }

        }
        void azalan()
        {
            for (int a = 5; a >= 1; a--)
            {
                int sonuc = 1;
                for (int i = 1; i <= a; i++)
                {
                    sonuc = i * sonuc;
                }
                listBox1.Items.Add(sonuc.ToString());
            }
        }

        void artan()
        {
            for (int a = 1; a <= 5; a++)
            {
                int sonuc = 1;
                for (int i = 1; i <= a; i++)
                {
                    sonuc = i * sonuc;

                }
                listBox1.Items.Add(sonuc.ToString());
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
