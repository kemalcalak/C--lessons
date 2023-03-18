using System;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var k = (char)Console.Read();
            if(char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!");
            }else if(char.IsLower(k)) 
            {
                Console.WriteLine("Kucuk karakter.");
            }else if (char.IsUpper(k))
            {
                Console.WriteLine("Büyük karakter.");
            }else 
            { 
                Console.WriteLine("Bilinmeyen karakter."); 
            }

            Console.ReadKey();
        }
        private static void TekMiCiftMiOrnegi()
        {
            // tek / çift
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayıdır.");
            }

            Console.ReadKey();
        }
        private static void MutlakDegerOrnegi()
        {
            int n= Convert.ToInt32(Console.ReadLine());
            if(n<0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }
    }
}
