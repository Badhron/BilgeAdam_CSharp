using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    class Airbus : Airplane
    {
        public string AirBusModel { get; set; }

        public void ModelShow()
        {
            MessageBox.Show("Airbus Type Airplane : " + AirBusModel);
        }
    }
}
