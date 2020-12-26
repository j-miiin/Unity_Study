using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 전달하는 변수를 초기화 없이 사용 가능
// out 키워드

namespace _063_Func_out
{
    class Program
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }
        static void InitRefNum(ref int refNum)
        {
            refNum = 100;
        }
        static void Main(string[] args)
        {
            int a;
            int b;

            InitNum(out a);
            Console.WriteLine("a: " + a);

            // b = 0;
            InitRefNum(ref b);  // 오류 : b를 초기화 하지 않고 사용 불가
            Console.WriteLine("b: " + b);
        }
    }
}
