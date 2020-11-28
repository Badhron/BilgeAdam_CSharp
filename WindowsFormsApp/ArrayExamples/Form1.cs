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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String[] days = { "pazartesi", "sali", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };
                string day = textBox1.Text;
                /*
                switch (day){
                    case "1":
                        MessageBox.Show(days[1]);
                        break;
                    case "2":
                        MessageBox.Show(days[2]);
                        break;
                    case "3":
                        MessageBox.Show(days[3]);
                        break;
                    case "4":
                        MessageBox.Show(days[4]);
                        break;
                    case "5":
                        MessageBox.Show(days[5]);
                        break;
                    case "6":
                        MessageBox.Show(days[6]);
                        break;
                    case "7":
                        MessageBox.Show(days[7]);
                        break;
                 */
                for (int i = 0; i < days.Length; i++)
                {
                    if (day == days[i])
                    {
                        MessageBox.Show(day + " günü haftanın " + (i + 1) + ". günüdür");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Var!!!" + ex.Message);
            }
           
        }
    }
}

