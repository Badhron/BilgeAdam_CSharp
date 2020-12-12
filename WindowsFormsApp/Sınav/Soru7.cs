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
    public partial class Soru7 : Form
    {
        public Soru7()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("yeme"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ekmek");
                comboBox2.Items.Add("yumurta");
            }
            if (comboBox1.SelectedItem.Equals("içme"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("süt");
                comboBox2.Items.Add("su");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox2.SelectedItem);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
    
}
