using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Airbus airbus = new Airbus();
            airbus.Weight = 260000;
            airbus.Length = 34.15;
            airbus.Height = 9.7;

            airbus.AirBusModel = "Airbus A340";

            airbus.ModelShow();

            airbus.TechnicalInformation();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Boeing boeing = new Boeing();
            boeing.Weight = 240000;
            boeing.Length = 44.15;
            boeing.Height = 11.7;

            boeing.BoeingModel = "Boeing 747";

            boeing.ModelShow();

            boeing.TechnicalInformation();
        }
    }
}
