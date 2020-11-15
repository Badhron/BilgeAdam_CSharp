using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                while (true)
                {
                    int ProcessNo, Sayı1, Sayı2;
                    double Add, Subtract, Multiply, Divide;

                    Console.WriteLine("Toplama : 1 " + "Çıkarma : 2 " + "Çarpma : 3 " + "Bölme : 4 ");
                    Console.Write("Yapılacak işlemi seçiniz : ");
                    ProcessNo = Convert.ToInt32(Console.ReadLine());

                    if (ProcessNo < 5 || ProcessNo < 0)
                    {
                        Console.WriteLine("Sayı 1 giriniz");
                        Sayı1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Sayı 2 giriniz");
                        Sayı2 = Convert.ToInt32(Console.ReadLine());

                        switch (ProcessNo)
                        {
                            case 1:
                                Add = Sayı1 + Sayı2;
                                Console.WriteLine("Toplama işlemi sonuç : {0}" + Add);
                                break;
                            case 2:
                                Subtract = Sayı1 - Sayı2;
                                Console.WriteLine("Çıkarma işlemi sonuç : {0}" + Subtract);
                                break;
                            case 3:
                                Multiply = Sayı1 * Sayı2;
                                Console.WriteLine("Çarpma işlemi sonuç : {0}" + Multiply);
                                break;
                            case 4:
                                Divide = Sayı1 / Sayı2;
                                Console.WriteLine("Bölme işlemi sonuç : {0}" + Divide);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem Numarası");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
            Console.ReadKey();

        }
    }
}