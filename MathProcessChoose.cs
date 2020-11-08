using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int ProcessNo;
            Double Sayı1, Sayı2, Toplama, Çıkarma, Çarpma, Bölme;

            while (true)
            {
                Console.WriteLine("Yapılacak işlemi seçiniz");
                Console.WriteLine("Toplama : 1 " + "Çıkarma : 2 " + "Çarpma : 3 " + "Bölme : 4 ");
                ProcessNo = Convert.ToInt32(Console.ReadLine());

                if (ProcessNo < 5 || ProcessNo < 0)
                {
                    Console.WriteLine("Sayı 1 giriniz");
                    Sayı1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sayı 2 giriniz");
                    Sayı2 = Convert.ToDouble(Console.ReadLine());

                    if (ProcessNo.Equals(1))
                    {
                        Toplama = Sayı1 + Sayı2;
                        Console.WriteLine("Toplama işlemi sonuç :" + Toplama);
                        break;
                    }
                    else if (ProcessNo.Equals(2))
                    {
                        Çıkarma = Sayı1 - Sayı2;
                        Console.WriteLine("Çıkarma işlemi sonuç :" + Çıkarma);
                        break;
                    }
                    else if (ProcessNo.Equals(3))
                    {
                        Çarpma = Sayı1 * Sayı2;
                        Console.WriteLine("Çarpma işlemi sonuç :" + Çarpma);
                        break;
                    }
                    else if (ProcessNo.Equals(4))
                    {
                        Bölme = Sayı1 / Sayı2;
                        Console.WriteLine("Bölme işlemi sonuç :" + Bölme);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı işlem Numarası");
                }
            }
            Console.ReadKey();
        }
    }
}
