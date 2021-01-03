using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스의 확장 함수

namespace _087_extension
{
    class AA
    {
        public void View(string str)
        {
            Console.WriteLine("PrintAA {0}", str);
        }
    }

    static class Util
    {
        public static void Print(this AA aa, string str)
        {
            aa.View(str);
        }

        public static void Sum(this int a)
        {
            Console.WriteLine("{0} + {1} = {2}", a, a, a + a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();

            Util.Print(aa, "Hello");
            aa.Print("Hello");  // 가능! -> 클래스의 함수를 확장

            Util.Sum(10);   // 10 자체가 클래스의 객체가 된 느낌 
            10.Sum();   // 이게 가능하다!!!
        }
    }
}
