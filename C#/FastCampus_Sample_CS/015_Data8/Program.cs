using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// char형이 아스키 코드값을 사용하는 정수형 데이터와 같다

namespace _015_Data8
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            int num = a;

            Console.WriteLine("문자: {0}, 아스키코드값: {1}, 문자 캐스트 연산: {2}", a, num, (char)num);
        }
    }
}
