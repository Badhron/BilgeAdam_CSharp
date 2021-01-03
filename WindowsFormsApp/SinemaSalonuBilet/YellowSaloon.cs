using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSalonuBilet
{
    public class YellowSaloon : Saloons
    {
        public YellowSaloon()
        {
            reservedSeatCount = 0;
            seatCount = 100;
        }

        public double Price(int full, double student)
        {
            return (double)((fullTicket * full) + (studentTicket * student));
        }

        public void BuySeat(int full, int student)
        {
            reservedSeatCount += (full + student);
        }

        public double RemainingSeat(int full, int student)
        {
            return (int)(seatCount - reservedSeatCount);
        }

        public double ReservedSeat(int full, int student)
        {
            //reservedSeatCount += full + student;
            return (int)(reservedSeatCount);
        }
    }
}
