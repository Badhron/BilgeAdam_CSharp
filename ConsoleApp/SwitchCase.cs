using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            String İçecek;
            Console.WriteLine("İçecek Kodu girin");
            Console.WriteLine("Çay : Ç " + "Limonata : L " + "Meyvesuyu : M ");
            İçecek = Console.ReadLine().ToLower();

            switch (İçecek)
            {
                case "ç":
                    Console.WriteLine("Çay seçildi");
                    break;

                case "m":
                    Console.WriteLine("Meyvesuyu seçildi");
                    break;

                case "l":
                    Console.WriteLine("Limonata");
                    break;
            }
            */

            double Vize, Final, Ortalama;
            int DersNotu = 0;

            Console.WriteLine("Vize Notunu girin");
            Vize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final Notunu girin");
            Final = Convert.ToDouble(Console.ReadLine());

            Ortalama = (Vize * 0.4) + (Final * 0.6);

            if (Ortalama < 45 && Ortalama > 0) { DersNotu = 1; }
            else if (Ortalama >= 45 && Ortalama < 60) { DersNotu = 2; }
            else if (Ortalama >= 60 && Ortalama < 70) { DersNotu = 3; }
            else if (Ortalama >= 70 && Ortalama < 85) { DersNotu = 4; }
            else if (Ortalama >= 85 && Ortalama < 101) { DersNotu = 5; }
            else { Console.WriteLine("Notlar yanlış girildi"); }

            switch (DersNotu)
            {
                case 1:
                    Console.WriteLine("Kaldı");
                    break;
                case 2:
                    Console.WriteLine("Geçer");
                    break;
                case 3:
                    Console.WriteLine("Orta");
                    break;
                case 4:
                    Console.WriteLine("İyi");
                    break;
                case 5:
                    Console.WriteLine("Pekiyi");
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;
            }

            Console.ReadKey();
        }

    }
}

