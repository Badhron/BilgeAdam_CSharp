using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Double fiyat, YeniFiyat;
            string Cinsiyet;

            Console.WriteLine("Fiyatı giriniz");
            fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cinsiyet giriniz");
            Cinsiyet = (Console.ReadLine()).ToLower();
           
            if (Cinsiyet.Equals("erkek") || Cinsiyet.Equals("bay"))
            {
                YeniFiyat = (fiyat - (fiyat * 0.1));
                Console.WriteLine("İndirimli fiyat : " + YeniFiyat);
            }
            else if (Cinsiyet.Equals("kadın") || Cinsiyet.Equals("bayan"))
            {
                YeniFiyat = (fiyat - (fiyat *0.18));
                Console.WriteLine("İndirimli fiyat : " + YeniFiyat);
            }
            Console.ReadKey();
        }
    }
}

