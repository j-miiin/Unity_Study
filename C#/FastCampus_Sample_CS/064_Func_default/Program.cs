using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 디폴트 매개 변수
// 반드시 뒤에서부터 순차적으로 초기화

namespace _064_Func_default
{
    class Program
    {
        static void PrintValue(int a, int b, int c = 100, int d = 0)    // c를 초기화 안하고 b를 초기화 --> 불가능 
        {
            Console.WriteLine("PrintValue: {0}  {1}  {2}  {3}", a, b, c, d);
        }
        static void Main(string[] args)
        {
            PrintValue(0, 0, 0, 0);
            PrintValue(100, 2, 1);
            PrintValue(300, 300);
        }
    }
}
