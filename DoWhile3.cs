using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          int guess = 0,Remain=5;

            Random random = new Random();
            int sayı = random.Next(0, 100);

            Console.Write("Guess Number between 0-100 : ");

            do
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess <= 100 && guess >= 0)
                {
                    if(Remain > 1)
                    {
                        if (guess > sayı)
                        {
                            Remain--;
                            Console.WriteLine("Remaining guesses : " + Remain);
                            Console.Write("Guess Lower Number : ");

                        }
                        else if (guess < sayı)
                        {
                            Remain--;
                            Console.WriteLine("Remaining guesses : " + Remain);
                            Console.Write("Guess Bigger Number : ");
                        }
                    }
                    else
                    {
                        Console.Write("Game Over!");
                        break;
                    }
                }
                else
                {
                    Console.Write("Guess Number Between 0-100 : ");
                }
            } while (guess != sayı);

            if (guess == sayı)
            {
                Console.WriteLine("Gratz!");
            }
            Console.ReadKey();
        }
    }
}
