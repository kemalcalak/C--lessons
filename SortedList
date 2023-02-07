using System;
using System.Collections;
using System.Collections.Generic;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SortedList - Temeller
            // Tanımlama
            var list = new SortedList()
            {
                {1, "Bir" },{2, "İki" },{5,"Beş"},{6,"Altı"}
        };
            list.Add(3, "Üç");
            list.Add(8, "Sekiz");
            // Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("Listedeki eleman sayısı : {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi     : {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin kapasitesi     : {0}", list.Capacity);

            // Erişme
            // Key
            Console.WriteLine(list[4]);
            // Index
            Console.WriteLine(list.GetByIndex(0));
            // Get -> Key
            Console.WriteLine(list.GetKey(0));
            // Liste sonundaki elemanın değeri
            Console.WriteLine(list.GetByIndex(list.Count-1));

            var anahtarlar = list.Keys;
            Console.WriteLine("\nANAHTARLAR");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            Console.WriteLine("\nDEGERER");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }





            Console.ReadKey();
        }
    }
}
