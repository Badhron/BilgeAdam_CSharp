using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, surname;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            surname = Console.ReadLine();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(name + " " + surname);
            }
            Console.ReadKey();
        }
    }
}
