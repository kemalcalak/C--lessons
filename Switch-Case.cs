using System;

namespace BTKAkademi
{
    public class Program
    {
        enum Islemler
        {
            Toplama,
            Cikarma,
            Carpma,
            Bolme
        }
        static void Main(string[] args)
        {
            Islemler secim = (Islemler) (new Random().Next(1,4));
            int A=40,B=20;
            switch (secim)
            {
                case Islemler.Toplama: 
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A} * {B} = {A * B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A} / {B} = {A / B}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz işlem!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
