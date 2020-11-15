using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.WriteLine("Enter Number");
            sayı = Convert.ToInt32(Console.ReadLine());

            if(sayı >= 5)
            {
                for(int i = sayı; i>0; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Enter Number Bigger Than 5");
            }
            Console.ReadKey();
        }
    }
}
