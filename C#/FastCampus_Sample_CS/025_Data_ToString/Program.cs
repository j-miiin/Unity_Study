using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ToString 기초

namespace _025_Data_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.1415926535897932384626433832m;

            string strA = a.ToString(); // "100"
            string strB = b.ToString(); // "3.141593"
            string strC = c.ToString();
            // 유니티에서는 화면에 숫자를 찍을 때 문자열로 변환하는 경우가 빈번함

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
        }
    }
}
