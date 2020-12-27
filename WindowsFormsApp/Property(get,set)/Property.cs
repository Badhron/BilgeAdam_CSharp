using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Property
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public string Curreny { get; set; }

        public void PrintAll()
        {
            MessageBox.Show("Country => " + Country + "\n" + "Capital => " + Capital + "\n" + "Curreny => " + Curreny);
        }
    }
}
