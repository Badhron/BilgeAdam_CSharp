using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          int Input = 0, factorial = 1, Sayı = 0;

            Console.Write("Enter number between 0-5 : ");

            while (true)
            {
                Input = Convert.ToInt32(Console.ReadLine());
                Sayı = Input;
                if (Input >= 0 && Input < 6)
                {
                    while (Input > 0)
                    {
                        factorial = factorial * Input;
                        Input--;
                    }
                    break;
                }
                else
                {
                    Console.Write("Enter number between 0-5 : ");
                }
            }
            Console.WriteLine(Sayı + " factorial : " + factorial);
            Console.ReadKey();
        }
    }
}
