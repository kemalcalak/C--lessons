using System;
using System.Collections.Generic;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Queue
            // Tanımlama
            var karakterKuyrugu = new Queue<char>();

            // Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Kapasite: {karakterKuyrugu.Count}");

            // Diziye atama
            var dizi = karakterKuyrugu.ToArray();


            // Çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkaerıldı.");
            Console.WriteLine($"Kapasite: {karakterKuyrugu.Count}");


            Console.ReadKey();
        }
    }
}
