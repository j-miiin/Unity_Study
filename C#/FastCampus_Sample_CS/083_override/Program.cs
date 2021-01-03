using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 다형성 - virtual, override
// - 객체 지향의 핵심
// - 함수의 오버라이딩(재정의)
// - 반복문으로 객체 관리

// sealed 키워드 -> 상속, 재정의 불가
// - sealed class CC -> 상속 불가
// - public sealed override void Print() -> 오버라이드 불가

namespace _083_override
{
    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("num:   {0}", num);
        }
    }

    class AA : Super
    {
        public int a;

        public override void Print()
        {
            base.Print();   // 없어도 되기는 함 

            Console.WriteLine("AA a:   {0}", a);
        }
    }

    class BB : Super
    {
        public int b;

        public override void Print()
        {
            base.Print();

            Console.WriteLine("BB b:   {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            super.Print();

            Super aa = new AA();
            aa.Print();

            Super bb = new BB();
            bb.Print();
        }
    }
}
