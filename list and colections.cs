using System.Collections;

namespace Apps 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //array
            var arrChar = new char[3] { 'b', 'c', 'a' };

            //arraylist -  type-safe
            //  10 -> boxing->object
            // b->boxing -> object
            var arrObj = new ArrayList();
            arrObj.Add("b");
            arrObj.Add(0);
            arrObj.Add("c");

            //list<T>
            var arrInt = new List<int>();
            arrInt.Add(1);
            arrInt.Add('a');
            arrInt.AddRange(new int[] { 1, 2, 3 });
            arrInt.RemoveAt(0);
            foreach(var item in arrObj)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
