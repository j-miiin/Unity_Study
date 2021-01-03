using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// base 키워드 : 클래스 상속
// - 부모의 생성자를 불러서 parameter를 넣을 수 있음
// - 부모의 멤버 메소드를 호출 가능

namespace _081_03_class_base
{
    class Super
    {
        int num;
        protected string name;

        public Super(int num)
        {
            this.num = num;
        }

        public void PrintSuper()
        {
            Console.WriteLine("Super   num: {0}", num);
        }
    }

    class Sub : Super
    {
        string name;

        public Sub(int num, string name) : base(num)    // base(num) 꼭 해줘야 함
        {
            this.name = name;
        }

        public void PrintSub()
        {
            base.name = "Super";
            base.PrintSuper();

            Console.WriteLine("Super   name: {0}", base.name);
            Console.WriteLine("Sub   name: {0}", this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(26, "Jack");
            sub.PrintSub();
        }
    }
}
