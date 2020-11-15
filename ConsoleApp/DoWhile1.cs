using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         int i = 0;
            do
            {
                Console.WriteLine("Hello World");
                i++;
            }
            while (i < 10);
            Console.ReadKey();
        }
    }
}
