using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// partial 키워드
// - 클래스를 나누어서 구현
// - 컨텐츠별 구분해서 코딩 가능

namespace _086_partial
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.SetNum(10);
            aa.ADD();

            aa.SetNum(100);
            aa.MUL();
        }
    }
}
