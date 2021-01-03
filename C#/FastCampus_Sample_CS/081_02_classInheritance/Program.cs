using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 상속 - 생성자, 소멸자

namespace _081_02_classInheritance
{
    class Super
    {
        protected int a;

        public Super()
        {
            a = 100;
            Console.WriteLine("   Call Super 생성자 호출");
        }

        ~Super()
        {
            Console.WriteLine("   Call Super 소멸자 호출");
        }
    }

    class Sub : Super
    {
        public Sub()
        {
            a = 100;
            Console.WriteLine("Call Sub 생성자 호출");
        }

        ~Sub()
        {
            Console.WriteLine("Call Sub 소멸자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();

            Sub sub = new Sub();    // 자식 클래스가 객체를 만들면 부모의 변수나 메소드를 사용해야 하므로 부모가 먼저 만들어짐
        }
    }
}
