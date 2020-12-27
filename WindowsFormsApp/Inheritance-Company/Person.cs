using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Person // Base Class
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void Show()
        {
            MessageBox.Show(Name + " " + Surname + " " + City + " " + Age + " " + Gender);
        }
    }
}
