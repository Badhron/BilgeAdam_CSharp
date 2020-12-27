using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Temperature
{
    class Celcius : Convert
    {
        public double ConvertToCelcius()
        {
            return (Value - 32) / 1.8;
        }
    }
}
