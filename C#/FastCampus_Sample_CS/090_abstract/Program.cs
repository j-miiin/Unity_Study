using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상클래스
// - 인스턴스 생성 불가(참조 가능)
// - 구현부 없음
// - 상속 받는 클래스의 규격

namespace _090_abstract
{
    abstract class abstractAA
    {
        protected int num;

        public abstractAA(int num)
        {
            this.num = num;
        }

        public abstract void abstractPrint();   // 무조건 오버라이드 해야 함

        public virtual void virtualPrint()
        {
            Console.WriteLine("abstractAA virtual void virtualPrint()");
        }

        public void Print()
        {
            Console.WriteLine("abstractAA Print()");
        }
    }

    class AA : abstractAA
    {
        public AA(int num) : base(num)
        {
            Console.WriteLine("num: {0}", num);
        }

        public override void abstractPrint()
        {
            Console.WriteLine("AA   override void abstractPrint()");
        }

        public override void virtualPrint()
        {
            base.virtualPrint();

            Console.WriteLine("AA   override void virtualPrint()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.abstractPrint();
            aa.virtualPrint();
            aa.Print();

            // abstractAA aaa = new abstractAA(10); -> 불가
        }
    }
}
