using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 함수 기초 : 리턴형 O, 파라미터 O

namespace _060_Func3
{
    class Program
    {
        static int Square(int i)
        {
            int input = i;
            return input * input;   // return i * i;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int resultA = Square(a);    // F12(함수 이름 위에 포커스 두고 누르면 그 함수로 이동함), Alt+F12(함수 이름 위에 포커스 두고 누르면 밑에 함수 내용 나옴)
            Console.WriteLine("resultA: " + resultA);

            int b = 4;
            int resultB = Square(b);
            Console.WriteLine("resultA: " + resultB);

            int resultC = Square(6);
            Console.WriteLine("resultA: " + resultC);

            resultC = Square(resultA * 3);
            Console.WriteLine("resultA: " + resultC);
        }
    }
}
