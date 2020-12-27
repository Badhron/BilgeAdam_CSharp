using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Temperature
{
    class Fahrenheit : Convert
    {
        public double ConvertToFahrenheit()
        {
            return (Value * 1.8) + 32; 
        }
    }
}
