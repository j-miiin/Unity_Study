using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// new 키워드 : 클래스의 객체 생성
// 클래스명 객체명 = new 생성자

// 생성자 (new)
// - 클래스 명 동일
// - 리턴형 X
// - 접근 한정자 public
// - 멤버 변수 초기화
// - 객체 생성시 자동으로 처리하는 것들

// 소멸자 (GC)
// - 클래스 명 동일
// - 리턴형 X
// - 접근 한정자 X
// - '~' 키워드로 구성 

// 클래스 생성자, 소멸자

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA() // 생성자가 하나라도 생성되어 있으면 기본생성자 만들어야 함
        {
            a = 0;
            f = 0f;
            Console.WriteLine("   Call Constructor   ");
            Console.WriteLine("   a : {0}", a);
            Console.WriteLine("   f : {0}", f);
        }
        public AA(int _a)   // 오버로딩
        {
            a = _a;

            Console.WriteLine("   Call Constructor   ");
            Console.WriteLine("   a : {0}", a);
            Console.WriteLine("   f : {0}", f);
        }
        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;
            Console.WriteLine("   Call Constructor   ");
            Console.WriteLine("   a : {0}", a);
            Console.WriteLine("   f : {0}", f);
        }

        ~AA()   // 소멸자에는 parameter 넣을 수 없음
        {
            Console.WriteLine("   Call Destructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA aaa = new AA(10);
            AA aaaa = new AA(100, 0.5f);

            // 소멸자는 자동으로 불려짐, 프로그램이 끝나므로 소멸자 3번 호출됨
        }
    }
}
