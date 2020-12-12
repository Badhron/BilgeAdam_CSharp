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
    public partial class Soru5 : Form
    {
        int sayı1, sayı2, sayı3, sayı4, sayı5, sayı6;

        public Soru5()
        {
            InitializeComponent();
            Random rnd = new Random();
            sayı1 = rnd.Next(0, 45);
            sayı2 = rnd.Next(0, 45);
            sayı3 = rnd.Next(0, 45);
            sayı4 = rnd.Next(0, 45);
            sayı5 = rnd.Next(0, 45);
            sayı6 = rnd.Next(0, 45);

        }

        private void Soru4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        void kontrol()
        {   
            int guess1 = Convert.ToInt32(textBox1.Text);
            int guess2 = Convert.ToInt32(textBox2.Text);
            int guess3 = Convert.ToInt32(textBox3.Text);
            int guess4 = Convert.ToInt32(textBox4.Text);
            int guess5 = Convert.ToInt32(textBox5.Text);
            int guess6 = Convert.ToInt32(textBox6.Text);

            if(sayı1 == guess1)
            {
                textBox1.Enabled = false;
            }
            if (sayı2 == guess2)
            {
                textBox2.Enabled = false;
            }
            if (sayı3 == guess3)
            {
                textBox3.Enabled = false;
            }
            if (sayı4 == guess4)
            {
                textBox4.Enabled = false;
            }
            if (sayı5 == guess5)
            {
                textBox5.Enabled = false;
            }
            if (sayı6 == guess6)
            {
                textBox6.Enabled = false;
            }
        }
    }
}
