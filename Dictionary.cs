using System;
using System.Collections;
using System.Collections.Generic;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionary

            var telefonKodlari=new Dictionary<int, string>()
            {
                {322, "Konya" }
                , {424,"Elezığ"}
            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            
            // Erişme
            telefonKodlari[466] = "Artvin";

            // ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");
            }

            // ContainsValue

            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");
            }


            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
