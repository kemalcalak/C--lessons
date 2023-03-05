using System;
using System.Collections.Generic;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SortedSet
            
            // Tanımlama
            var list= new SortedSet<string>();

            // Ekleme
            if (list.Add("Ahmet"))
            {
                Console.WriteLine("A eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız.");
            }

            Console.WriteLine("{0}",list.Add("Busra")==true ?
                "B eklendi" : "Ekleme başarısız");

            list.Add("Canan");
            list.Add("Deniz");
            list.Add("Eren");
            list.Add("Furkan");

            

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            list.Remove("Canan");
            list.RemoveWhere(deger => deger.Contains("a"));

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Eleman sayısı  :{0}", list.Count);

            Console.ReadKey();
        }
    }
}
