using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    class Boeing : Airplane
    {
        public string BoeingModel { get; set; }

        public void ModelShow()
        {
            MessageBox.Show("Boeing Type Airplane : " + BoeingModel);
        }
    }
}
