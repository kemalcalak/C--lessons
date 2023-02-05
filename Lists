using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            List<int> sayilar= new List<int>();
            int x = 55;
            int[] seri = new int[] { 70, 80, 90 };

            // Ekleme
            sayilar.Add(10);
            sayilar.Add(15);
            sayilar.Add(20);
            sayilar.Add(x);     
            foreach (int i in seri)
            {
                sayilar.Add(i);
            }
            //sayilar.AddRange(seri);

            // Araya ekleme
            sayilar.Insert(3, 0);
            sayilar.InsertRange(4, new int[] { 80, 90 });

            // Silme
            sayilar.RemoveAt(3);
            sayilar.RemoveAt(sayilar.IndexOf(55));



            // Dolaşma
            foreach(int s in sayilar) 
            {
                Console.Write($"{s,-5}");
            }

            
            Console.ReadKey();
        }
    }
}
