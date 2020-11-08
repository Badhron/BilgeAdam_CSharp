using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int KursNumarası;

            while (true)
            {
                Console.WriteLine("Kurs Numarasını giriniz");
                KursNumarası = Convert.ToInt32(Console.ReadLine());

                if (KursNumarası.Equals(1))
                {
                    Console.WriteLine("Seçilen Kurs : C#");
                    break;
                }
                else if (KursNumarası.Equals(2))
                {
                    Console.WriteLine("Seçilen Kurs : Java");
                    break;
                }
                else if (KursNumarası.Equals(3))
                {
                    Console.WriteLine("Seçilen Kurs : JavaScript");
                    break;
                }
                else if (KursNumarası.Equals(4))
                {
                    Console.WriteLine("Seçilen Kurs : Python");
                    break;
                }
                else if (KursNumarası.Equals(5))
                {
                    Console.WriteLine("Seçilen Kurs : Swift");
                    break;
                }
                else
                {
                    Console.WriteLine("Kurs numarası yanlış");
                }
            }
            Console.ReadKey();
        }
    }
}
