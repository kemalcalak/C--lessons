using System;
using System.Collections;
using System.Collections.Generic;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Sayı Giriniz: ");
            x = (int)Convert.ToInt32(Console.ReadLine());
            y =(int)Convert.ToInt32(Console.ReadLine());
            Karsilastir(x,y);
            Console.ReadKey();
        }
        public static int Karsilastir(int sayi1, int sayi2)
        {
            int gecici;
            if(sayi1< sayi2) 
            {
                gecici = sayi1;
                sayi1 = sayi2;
                sayi2= gecici;
            }
            Console.WriteLine($"{sayi1} > {sayi2}");
            return 0;
            // return sayi1 > sayi2 ? sayi1 : sayi2 ;
        }
        static double KareAl(double x) 
        {
            double kare = x * x;
            return kare;
        }

    }
}
