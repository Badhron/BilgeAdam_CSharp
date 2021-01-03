using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSalonuBilet
{
    public partial class Form1 : Form
    {
        RedSaloon red;
        BlueSaloon blue;
        GreenSaloon green;
        YellowSaloon yellow;

        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            if (comboBox1.SelectedItem.Equals("Red"))
            {
                if (red.CheckSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) == true)
                {
                    red.BuySeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    MessageBox.Show("Price :" + "  " + Convert.ToString(red.Price(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Red");
                    MessageBox.Show("Remaining Seat :" + "  " + Convert.ToString(red.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Red");
                    MessageBox.Show("Reserved Seat :" + "  " + Convert.ToString(red.ReservedSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Red");
                    label6.Text = red.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
                    listBox3.Visible = true;
                    label9.Visible = true;                   
                    AddtoList();
                }
            }
            else if (comboBox1.SelectedItem.Equals("Blue"))
            {
                if (blue.CheckSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) == true)
                {// Parse ile yazıldı değişiklik olsun :D
                    blue.BuySeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    MessageBox.Show("Price :" + "  " + blue.Price(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString(),"Blue");
                    MessageBox.Show("Remaining Seat :"+"  "+blue.RemainingSeat(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString(),"Blue");
                    MessageBox.Show("Reserved Seat :" + "  " + blue.ReservedSeat(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString(), "Blue");
                    label6.Text = blue.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
                    listBox1.Visible = true;
                    label7.Visible = true;                 
                    AddtoList();
                }
            }
            else if (comboBox1.SelectedItem.Equals("Yellow"))
            {
                if (yellow.CheckSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) == true)
                {
                    yellow.BuySeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    MessageBox.Show("Price :" + "  " + Convert.ToString(yellow.Price(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Yellow");
                    MessageBox.Show("Remaining Seat :" + "  " + Convert.ToString(yellow.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Yellow");
                    MessageBox.Show("Reserved Seat :" + "  " + Convert.ToString(yellow.ReservedSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Yellow");
                    label6.Text = yellow.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
                    listBox4.Visible = true;
                    label10.Visible = true;
                    AddtoList();
                }
            }
            else if (comboBox1.SelectedItem.Equals("Green"))
            {
                if (green.CheckSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) == true)
                {
                    green.BuySeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    MessageBox.Show("Price :" + "  " + Convert.ToString(green.Price(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Green");
                    MessageBox.Show("Remaining Seat :" + "  " + Convert.ToString(green.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Green");
                    MessageBox.Show("Reserved Seat :" + "  " + Convert.ToString(green.ReservedSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))), "Green");
                    label6.Text = green.RemainingSeat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
                    listBox2.Visible = true;
                    label8.Visible = true;
                    AddtoList();
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Red"))
            {
                red = new RedSaloon();
                red.seatCount = 100;
                red.reservedSeatCount = 0;
                label6.Text = red.seatCount.ToString();
            }
            else if (comboBox1.SelectedItem.Equals("Blue"))
            {
                blue = new BlueSaloon();
                blue.seatCount = 100;
                blue.reservedSeatCount = 0;
                label6.Text = blue.seatCount.ToString();
            }
            else if (comboBox1.SelectedItem.Equals("Yellow"))
            {
                yellow = new YellowSaloon();
                yellow.seatCount = 100;
                yellow.reservedSeatCount = 0;
                label6.Text = yellow.seatCount.ToString();
            }
            else if (comboBox1.SelectedItem.Equals("Green"))
            {
                green = new GreenSaloon();
                green.seatCount = 100;
                green.reservedSeatCount = 0;
                label6.Text = green.seatCount.ToString();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddtoList()
        {
            int i = Int32.Parse(textBox1.Text);
            int j = Int32.Parse(textBox2.Text);

            if (comboBox1.SelectedItem.Equals("Red"))
            {
                for (int a = 0; a < i; a++)
                {
                    listBox3.Items.Add("Full Ticket");
                }
                for (int b = 0; b < j; b++)
                {
                    listBox3.Items.Add("Student Ticket");
                }
            }
            else if (comboBox1.SelectedItem.Equals("Blue"))
            {
                for (int a = 0; a < i; a++)
                {
                    listBox1.Items.Add("Full Ticket");
                }
                for (int b = 0; b < j; b++)
                {
                    listBox1.Items.Add("Student Ticket");
                }
            }
            else if (comboBox1.SelectedItem.Equals("Green"))
            {
                for (int a = 0; a < i; a++)
                {
                    listBox2.Items.Add("Full Ticket");
                }
                for (int b = 0; b < j; b++)
                {
                    listBox2.Items.Add("Student Ticket");
                }
            }
            else if (comboBox1.SelectedItem.Equals("Yellow"))
            {
                for (int a = 0; a < i; a++)
                {
                    listBox4.Items.Add("Full Ticket");
                }
                for (int b = 0; b < j; b++)
                {
                    listBox4.Items.Add("Student Ticket");
                }
            }
        }
    }
}
