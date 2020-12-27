using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Accounting : Person
    {
        public bool DisplaySalary { get; set; }
        public bool ArrangeSalary { get; set; }

        public void ShowAccounting()
        {
            if (DisplaySalary && ArrangeSalary)
            {
                MessageBox.Show("Authorized");
            }
            else
            {
                MessageBox.Show("Not Authorized");
            }
        }
    }
}
