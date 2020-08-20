using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// var : 지역 변수로만 사용 가능
// var 데이터형 활용

namespace _022_Data_var
{
    class Program
    {
        // 불가 : 반드시 지역변수만 사용
        // var globalVar = 100;

        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.1415926535897932384626433332f;
            var c = 3.1415926535897932384626433332m;
            object d = 'H';
            object e = 'i';
            object f = "World!";
            object g = false;

            Console.WriteLine("type: {0}, a: {1}", a.GetType(), a);
            Console.WriteLine("type: {0}, b: {1}", b.GetType(), b);
            Console.WriteLine("type: {0}, c: {1}", c.GetType(), c);
            Console.WriteLine("type: {0}, g: {1}", g.GetType(), g);

            Console.WriteLine("{0}{1} {2}", d, e, f);

            // 불가 : 반드시 선언과 동시에 초기화
            //var noinitialvar;
            //noninitialvar = 100;

            var num = 0;
            num = 100;

            Console.WriteLine("num: " + num);
        }
    }
}
