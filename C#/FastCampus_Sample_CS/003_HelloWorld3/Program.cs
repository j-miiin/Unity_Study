using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HelloWorld3  // 형태가 다양한 Main 함수
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("static void Min(string[] args)");
        //}

        //static void Main()
        //{
        //    Console.WriteLine("static void Min(string[] args)");
        //}

        //static int Main()
        //{
        //    Console.WriteLine("static int Main");
        //    return 0;
        //}

        static int Main(string[] args)
        {
            Console.WriteLine("AAA{0} BBB{1}", 1, "ggg");
            Console.Write("{0}{1}{2}", 1, 2, 3);
            Console.WriteLine("static int Min(string[] args)");
            return 0;
        }
        // WriteLine : 출력 후 줄 바꿈
        // Write : 출력 후 줄 바꿈 X
    }
}
