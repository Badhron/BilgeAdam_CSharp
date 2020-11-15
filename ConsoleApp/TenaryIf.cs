// Öğrenci Ortalaması hesaplama 
// Ortalama 50 + ise geçer

using System;

namespace ÖğrenciSınav
{
    class Program
    {
        static void Main(string[] args)
        {
            double Vize, Final, Ortalama;

            Console.WriteLine("Vize Not");
            Vize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final Not");
            Final = Convert.ToDouble(Console.ReadLine());

            // Ternary if Kullanarak
            // Console.WriteLine((((Vize * 0.4) + (Final * 0.6)) >= 50) ? "Öğrenci Geçti." : "Öğrenci Kaldı.");
            
            Ortalama = (Vize*0.4) + (Final*0.6);

            if(Ortalama >= 50)
            {
                Console.WriteLine("Öğrenci Geçti." + "Ortalaması :" + Ortalama);
            }
            else if (Ortalama < 50 && Ortalama >= 0)
            {
                Console.WriteLine("Öğrenci Kaldı." + "Ortalaması :" + Ortalama);
                
            }
            Console.ReadKey();
        }

    }
}
