using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    class Airplane //Base Class
    {
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }

        public void TechnicalInformation()
        {
            MessageBox.Show("Weight : " + Weight + "\n" + "Length : " + Length + "\n" + "Height : " + Height);
        }
    }
}
