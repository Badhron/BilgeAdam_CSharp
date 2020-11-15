using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            while (true)
            {
                Console.WriteLine("Yaşınızı giriniz");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 18)
                {
                    Console.WriteLine("Okul Çağındasınız");
                    break;
                }
                else if ((Age == 18) && (Age >= 18 && Age < 30))
                {
                    Console.WriteLine("Gençsiniz");
                    break;
                }
                else if ((Age == 30) || (Age >= 30 && Age < 50))
                {
                    Console.WriteLine("Orta Yaşlısınız");
                    break;
                }
                else if (Age >= 50)
                {
                    Console.WriteLine("Yaşlısınız");
                    break;
                }
                else
                {
                    Console.WriteLine("yanlış girdi");
                }
            }
        }
    }
}

