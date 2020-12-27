using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Celcius celcius = new Celcius();
            celcius.Value = double.Parse(textBox2.Text);

            label3.Text = celcius.ConvertToCelcius().ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.Value = double.Parse(textBox1.Text);

            label3.Text = fahrenheit.ConvertToFahrenheit().ToString();
        }
    }
}
