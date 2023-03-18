using System;
using System.Collections;
using System.Collections.Generic;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };

            foreach (var s in sehirler)
            {
                Console.WriteLine(s);
            }

            // Lambda expression

            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string('-', 50));

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Add("Sinop");
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            iller.ForEach(s => Console.WriteLine(s));

            iller.Remove("Ankara");
            iller.ForEach(i=> Console.WriteLine(i));

            sehirler.ForEach(s=> Console.WriteLine(s));


            Console.ReadKey();
        }
    }
}
