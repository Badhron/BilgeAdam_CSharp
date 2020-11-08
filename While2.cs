using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int Input=0, factorial= 1;

            Console.WriteLine("Enter number between 1-5");

            while(Input >= 0 && Input < 6)
            {
                Input = Convert.ToInt32(Console.ReadLine());

                if (Input > 0 && Input < 6)
                {
                    for(int i = 1; i <= Input; i++)
                    {
                        factorial = factorial * i;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Enter number between 1-5");
                }
            }
            Console.WriteLine(Input + " factorial : " + factorial);
            Console.ReadKey();
        }
    }
}
