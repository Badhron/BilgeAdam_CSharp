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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String path = "C:/Users/User/Desktop/DENEME";

            if (Directory.Exists(path))
            {
                Console.WriteLine("That path exists already.");
                return;
            }
            else
            {
                Directory.CreateDirectory(@path);
                MessageBox.Show("Created Directory");
            }           
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String Path = "C:/Users/User/Desktop";
            String[] Directories = Directory.GetDirectories(@Path);
            foreach (var item in Directories)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
