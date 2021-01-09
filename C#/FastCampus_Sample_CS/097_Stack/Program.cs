using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stack
// - 순차적 데이터 처리
// - LIFO(Last In First Out)
// - 뒤로 가기 기능 구현
// - Push(), Pop(), Peek()
// Stack stack = new Stack();
// - 접시 쌓아놓고 사용하는 것을 생각해보면 쉬움

namespace _097_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for(int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("stack data: {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("stack data: {0}, count: {1}", stack.Pop(), stack.Count);
            }

            // 배열 데이터로 초기화
            Console.WriteLine("배열 데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Stack stackCopy = new Stack(arrData);

            foreach(object data in stackCopy)
            {
                Console.WriteLine("stackCopy data: " + data);
            }
        }
    }
}
