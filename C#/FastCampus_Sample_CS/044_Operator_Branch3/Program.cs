using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 조건문에 &&, || 연산자 이용하기

namespace _044_Operator_Branch3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if (isA && isB)
            {
                Console.WriteLine("false && true => false");    // 실행 안됨!
            }

            if (isB && isC)
            {
                Console.WriteLine("true && true => true");
            }

            if (isC || isD)
            {
                Console.WriteLine("true && false => true");
            }

            if (2 > 1 && 3 < 4 || 1 > 2)    // 앞에서부터 차례대로 보기
            {
                Console.WriteLine("true && true || false => true");
            }
        }
    }
}
