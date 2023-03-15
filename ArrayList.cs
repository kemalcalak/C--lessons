using System.Collections;
using System;
using Microsoft.VisualBasic;


namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            var arrayList= new ArrayList()
            {
                10,"BTK Akademi",true,'e'
            };

            int[] sayilar = new int[] { 23, 44, 55 };
            arrayList.AddRange(sayilar);


            // Ekleme
            /*
            arrayList.Add(10);
            arrayList.Add("BTK Akademi");
            arrayList.Add(true);
            arrayList.Add('e');   */

            // Elemana erişme - atama
            var x = (int)arrayList[0];
            Console.WriteLine(x + 10);

            // Eleman silme
            //arrayList.Remove(10);
            //arrayList.RemoveAt(0);
            arrayList.RemoveRange(3, 3);

            // Dolaşma 
            Console.WriteLine();
            foreach (var e in arrayList) 
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            

            Console.ReadKey();
            
        }
    }
}
