using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 vs 구조체
//      - class : 참조 타입(Reference), 힙에 생성, new 연산자, parameter 없는 생성자 가능
//      - struct : 값 타입(Value), 스택에 생성, new 연산자 없는 생성 가능, 반드시 parameter 있어야 함
// - 자료의 크기가 작을 때
// - 구조가 단순할 때

namespace _088_struct
{
    struct AA
    {
        public int x;
        public int y;

        // public AA() { } -> 오류, parameter 없음
        public AA(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("x:   {0},   y:   {1}", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10, 20); // 이것도 가능 
            aa.x = 100;
            aa.Print();

            AA aaa;
            aaa.x = 100;
            aaa.y = 200;
            aaa.Print();

            AA copyAA = aa; // Value Type
            copyAA.x = 1000;
            aa.Print();
            copyAA.Print();
        }
    }
}
