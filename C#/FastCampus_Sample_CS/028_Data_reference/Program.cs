using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Reference 참조 기초
// 참조형 : 배열, string, class, interface, delegate -> 두 변수가 서로 영향 O
// 값형식 : char, bool, enum... -> 두 변수가 서로 영향 X

namespace _028_Data_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int refNum = num;
            refNum = 1000;

            Console.WriteLine("refStr: {0}      ReferenceEquals: {1}", num, Object.ReferenceEquals(num, refNum));

            int[] arrrNum = { 100, 200 };
            int[] refArrNum = arrrNum;
            refArrNum[0] = 1000;

            Console.WriteLine("refStr: {0}      ReferenceEquals: {1}", arrrNum[0], Object.ReferenceEquals(refArrNum, arrrNum));
        }
    }
}
