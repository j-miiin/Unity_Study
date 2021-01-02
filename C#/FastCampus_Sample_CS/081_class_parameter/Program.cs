using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스의 메소드 활용
// - 클래스가 메소드의 파라미터
// - 클래스가 메소드의 리턴형

namespace _081_class_parameter
{
    class AA
    {
        public int a;
        public int b;

        public AA()
        {
            a = 0;
            b = 0;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.Print();

            CopyRefClass(aa);
            aa.Print();

            AA aaa = CopyDeepClass(aa);
            aaa.Print();

            aa.Print();
        }

        static void CopyRefClass(AA aa)
        {
            AA refAA = aa;
            refAA.a = 100;
            refAA.b = 10000;
        }

        static AA CopyDeepClass(AA aa)
        {
            AA tempAA = new AA();

            tempAA.a = aa.a;
            tempAA.b = aa.b;
            tempAA.a = 0;

            return tempAA;
        }
    }
}
