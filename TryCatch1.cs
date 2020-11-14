using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.Write("1. Sayıyı Girin : ");
                int Sayı1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı Girin : ");
                int Sayı2 = Convert.ToInt32(Console.ReadLine());

                double division = Sayı1 / Sayı2;

                Console.WriteLine("Bölüm Sonucu : {0}", division);
            }
            /*
            catch(DivideByZeroException sıfır)
            {
                Console.WriteLine("Hata : {0}", sıfır.Message);
            }
            */
            catch (Exception ex)
            {
                Console.WriteLine("Hata : {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
