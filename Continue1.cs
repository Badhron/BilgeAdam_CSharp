using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input, Total=0;

            Console.Write("Enter Number Bigger Than 10 : ");
            Input =  Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= Input; i++)
            {
                if(i % 2 == 0)
                    {
                        Total += i;
                    }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Total of Even Numbers Till Input : " + Total);
            Console.ReadKey();
        }
    }
}
