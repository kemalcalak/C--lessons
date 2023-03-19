using System;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            //aritmetik oparetörler
            int A, B;
            A = 20;
            B = 10;
            /*
            Console.WriteLine(A+B);
            Console.WriteLine(B*A);
            Console.WriteLine(A/B);
            Console.WriteLine(A-B);
            Console.WriteLine(A%B); */

            //ilişkisel operatörler
            /*
            Console.WriteLine(A>B);
            Console.WriteLine(A<B);
            Console.WriteLine(A>=B);
            Console.WriteLine(A<=B);
            Console.WriteLine(A==B);
            Console.WriteLine(A!=B); */
            
            // Mantıksal öperatörler
            Console.WriteLine(!(A>B && A>5));
            Console.WriteLine(A<B || B>5);

            Console.ReadKey();
        }
    }
}
