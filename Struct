using System;
using System.Collections.Generic;

namespace BTKAkademi
{
    // tanımlama
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyAdi, bool cinsiyet)
        {
            Console.WriteLine("Otomatik çalıştı");
            Numara = numara;
            Adi = adi;
            SoyAdi = soyAdi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } // Property - Özellik
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public bool Cinsiyet { get; set; }



    }
    public class Program
    {
        static void Main(string[] args)
        {
            // struct - Kullanma
            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 10;
            ogr.Adi = "Ali Kemal";
            ogr.SoyAdi = "Çalak";
            ogr.Cinsiyet = true;


            // Alternatif kullanma
            var ogr2 = new Ogrenci()
            {
                Numara = 20,
                Adi = "Fatma",
                SoyAdi = "Yılmaz",
                Cinsiyet = false 
            };


            // Alternatif Kullanım
            var ogr3 = new Ogrenci(30, "Mehmet", "Yılmaz", true);




            Console.WriteLine($"{ogr.Numara} " + $" {ogr.Adi} {ogr.SoyAdi} " + $" {ogr.Cinsiyet} ");
            Console.WriteLine($"{ogr2.Numara} " + $" {ogr2.Adi} {ogr2.SoyAdi} " + $" {ogr2.Cinsiyet} ");
            Console.WriteLine($"{ogr3.Numara} " + $" {ogr3.Adi} {ogr3.SoyAdi} " + $" {ogr3.Cinsiyet} ");


            Console.ReadKey();
        }
    }
}
