using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public : 액세스가 제한되지 않음
// protected : 이 클래스 또는 이 클래스에서 파생된 클래스로만 액세스가 제한됨
// internal : 현재 어셈블리(.exe, .dll 등)로만 액세스가 제한됨
// protected internal : 포함하는 클래스, 포함하는 클래스에서 파생된 클래스 또는 동일한 어셈블리 내의 클래스로만 액세스가 제한됨
// private : 이 클래스로만 액세스가 제한됨
// private protected : 포함하는 클래스 또는 동일한 어셈블리 내의 포함하는 유형으로부터 파생된 클래스로만 액세스가 제한됨

// 클래스의 기본

namespace _077_class
{
    class AA
    {
        int num1;   // 기본적으로 private 속성
        public int num2, num3;

        public void Print()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }

        private void PrintPrivate()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            // aa.num1 = 10; -> 오류
            aa.num2 = 100;
            aa.num3 = 1000;

            aa.Print();
            
            // aa.PrintPrivate(); -> 오류
        }
    }
}
