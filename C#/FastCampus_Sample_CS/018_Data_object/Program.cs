using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// object형 기초

namespace _018_Data_object
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object b = 3.1415926535897932384626433332f;
            object c = 3.1415926535897932384626433332m;
            object d = 'H';
            object e = 'i';
            object f = "World!";
            object g = false;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("{0}{1} {2}", d, e, f);
            Console.WriteLine("g: {0}", g);

        }
    }
}
