using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// static 키워드
// - 클래스의 멤버를 객체 없이 사용 가능
// - 클래스 static 필드(변수)
// - 클래스 static 메소드(함수)
// - static 메소드 내부에 사용하는 변수는 반드시 static

namespace _080_static
{
    class AA
    {
        public static int a;
        public static int b;
        public static readonly int c = 200; // readonly -> 상수화

        public int num;

        public static void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            // num = 100 -> 오류
        }
    }

    class BB
    {
        public int a;
        public int b;

        public void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            AA.a = 10;
            AA.b = 100;
            // AA.c = 200; -> 오류

            AA.Print();

            // BB.a -> 오류

            BB bb = new BB();
            bb.a = 100;
            bb.b = 200;
            bb.Print();
        }
    }
}
