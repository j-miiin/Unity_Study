using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this 키워드
// - 객체 자신을 참조하는 키워드
// - 사용처
//  - 함수의 파라미터 이름과 멤버 변수 이름이 동일
//  - 클래스 내부에서 멤버변수를 접근

namespace _079_this
{
    class AA
    {
        int a;

        public AA(int a)
        {
            this.a = a;
        }

        public void Print()
        {
            int a = 100;
            this.a = 1000;

            Console.WriteLine("a: {0}", a); // 100, 커서 놓고 f11 눌러보면 알 수 있음
            Console.WriteLine("this.a: {0}", this.a);   // 1000
        }
    }

    class Program
    {    
        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.Print();
        }
    }
}
