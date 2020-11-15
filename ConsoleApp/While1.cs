using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          int guess = 0;

            Random random = new Random();
            int sayı = random.Next(0, 100);

            //Console.WriteLine("Guess Number between 0-100");
           Console.Write("Guess Number between 0-100 : ");

            while (guess != sayı)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                // guess = int.Parse(Console.ReadLine());
                if(guess < 101 && guess > -1)
                {
                    if (guess > sayı)
                    {
                        //Console.WriteLine("Guess Lower Number");
                        Console.Write("Guess Lower Number : ");
                    }
                    else if (guess < sayı)
                    {
                        //Console.WriteLine("Guess Bigger Number");
                        Console.Write("Guess Bigger Number : ");
                    }
                }
                else
                {
                    Console.Write("Guess Number Between 0-100 : ");
                }
            }
            Console.WriteLine("Gratz!");
            Console.ReadKey();
        }
    }
}
