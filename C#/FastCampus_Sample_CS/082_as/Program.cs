using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// is 키워드
// - 객체의 형식 검사
// - bool 리턴

// as 키워드 -> 예외처리 가능 
// - 형식 변환
// - null 리턴 

namespace _082_as
{
    class Base
    {
        int num;

        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Base
    {
        int a;

        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }
    }

    class BB : Base
    {
        int b;

        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA();
            aa.Print(); // PrintA 접근 불가

            if(aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체입니다");
            }
            else if (aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체입니다.");
            }

            Base bb = new BB();

            // BB copyBB = (BB)bb;  -> 캐스팅도 되기는 하는데 잘못된 캐스팅 연산을 하면 문제가 발생
            BB copyBB = bb as BB;   // 강제 형 변환
            if(null != copyBB)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("copyBB는 BB객체를 형식 변환!!");
                copyBB.PrintB();
            }

            // AA copyAA = (AA)bb;  -> 예외상황 발생
            AA copyAA = bb as AA;
            if (null == copyAA) // 정상적으로 캐스팅 연산이 되지 않았을 때 
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("copyAA는 AA객체가 아니므로 null!!");

                copyAA = new AA();
                copyAA.Print();
                // copyAA.PrintA(); -> 원하는 값이 나오지 않음 (=> 다형성으로 가능)

                AA asAA = copyAA as AA; // 강제 형변환
                asAA.PrintA();
            }
        }
    }
}
