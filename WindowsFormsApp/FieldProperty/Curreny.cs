using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldProperty
{
    class Curreny
    {
        double _Amount;
        double _ExchangeRate;
        int _Rate;

        public double Amount
        {
            get { return _Amount; }
            set
            {
                if (value > 10)
                {
                    _Amount = value;
                }
                else
                {
                    MessageBox.Show("Must be higher than 10TL");
                }
            }
        }


        public double ExchangeRate
        {
            get { return _ExchangeRate; }
            set
            {
                if (value > 7)
                {
                    _ExchangeRate = value;
                }
                else
                {
                    MessageBox.Show("ExchangeRate must be higher than 7 or eqaul to 7");
                }
            }
        }

        public int Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        public string Exchange()
        {
            double result;
            string exchange = "";
            if (_Amount > 10 && _Rate > 7)
            {
                result = _Amount / _Rate;
                switch (_ExchangeRate)
                {
                    case 0:
                        exchange = result.ToString() + " $";
                        break;
                    case 1:
                        exchange = result.ToString() + " €";
                        break;
                    case 2:
                        exchange = result.ToString() + " £";
                        break;
                    case 3:
                        exchange = result.ToString() + " ¥";
                        break;
                }
            } 
            return exchange;
        }
    }
}
