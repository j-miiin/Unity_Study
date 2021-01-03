using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스
// - 메소드, 이벤트, 인덱서, 프로퍼티
// - 필드 불가
// - 구현부 없음(정의)
// - 인스턴스 생성 불가(참조 가능)

namespace _089_interface
{
    interface IAA
    {
        // public int a; -> 필드 불가
        // private void IPrint() { } -> private 에러
        // public void IPrint(); -> public 에러
        int A { get; set; } // 프로퍼티 가능 
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;

        public virtual void Print() // virtual는 강제성 없음, 재정의 해도 되고 안해도 됨
        {
            Console.WriteLine("============================================");
        }
    }

    class AA : IAA
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IAAPrint()  // 무조건 재정의 해줘야 함
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
    }

    class BB : IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA에 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }

    class CC : Super, IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("class Super => Print() 재정의");
        }
        public void IAAPrint()
        {
            Console.WriteLine("class CC interface IAA에 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class CC interface IBB에 IBBPrint() 재정의");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.IAAPrint();

            BB bb = new BB();
            bb.IAAPrint();
            bb.IBBPrint();

            // IAA Iaaa = new IAA();    -> 인스턴스 생성 불가능 
            IAA Iaa = new AA(); // 참조 가능
            Iaa.IAAPrint();

            IBB Ibb = bb as IBB;    // 형변환 하는건 가능
            Ibb.IBBPrint();

            CC cc = new CC();
            cc.Print();
            cc.IAAPrint();
            cc.IBBPrint();

            Super sCC = cc as Super;
            sCC.Print();

            IAA IAAcc = cc as IAA;
            IAAcc.IAAPrint();

            IBB IBBcc = cc as IBB;
            IBBcc.IBBPrint();
        }
    }
}
