using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이벤트(event)
// - delegate와 차이점
//  - 할당 연산자(=) 사용 불가, +=나 -= 사용
//  - 클래스 외부 호출 불가
//  - 클래스 멤버 필드에서 사용
// - delegate보다 안전성 높아질 수 있음
// - delegate가 존재해야 event를 만들 수 있음

namespace _119_event
{
    public delegate void delegateEvent(string msg);

    class InDelegate
    {
        public delegateEvent myDelegate;
        public event delegateEvent myEvent;

        public void DoEvent(int a, int b)   // myEvent를 대신 호출해줄 함수
        {
            if (null != myEvent)
            {
                myEvent("DoEvent: " + (a + b)); // == ConsoleFunc("DoEvent: " + (a + B));
            }
        }
    }

    class Program
    {
        static public void ConsoleFunc(string msg)
        {
            Console.WriteLine("ConsoleFunc: " + msg);
        }

        static void Main(string[] args)
        {
            InDelegate id = new InDelegate();
            id.myEvent += new delegateEvent(ConsoleFunc);
            // id.myEvent += ConsoleFunc;
            // id.myEvent = ConsoleFunc;    -> 대입 연산자 사용 불가

            id.myDelegate = ConsoleFunc;

            id.myDelegate("Test");  // 클래스 외부에서 직접 호출 가능
            // id.myEvent("Test");  -> 클래스 외부에서 직접 호출 불가 

            for(int i = 0; i < 10; i++)
            {
                if (i == 9) id.myEvent -= ConsoleFunc;  // 21은 안 찍힘
                id.DoEvent(i + 1, i + 2);
            }
        }
    }
}
