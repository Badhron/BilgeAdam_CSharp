using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı, oddNumber, evenNumber;
            oddNumber = 0;
            evenNumber = 0;

            Console.WriteLine("Enter Number");
            sayı = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<= sayı; i++)
            {
                if(i % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
            }
            Console.WriteLine("odd Number count : " + oddNumber);
            Console.WriteLine("even Number count : " + evenNumber);
            Console.ReadKey();
        }
    }
}
