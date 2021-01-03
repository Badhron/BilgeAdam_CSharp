using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSalonuBilet
{
    public abstract class Saloons
    {
        public int seatCount { get; set; }
        public int reservedSeatCount { get; set; }

        public const int fullTicket = 15;
        public const double studentTicket = 7.5;

        public bool CheckSeat(int full, int student)
        {
            if (reservedSeatCount + full + student > seatCount)
            {
                MessageBox.Show("Not Enough Place","Error!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
