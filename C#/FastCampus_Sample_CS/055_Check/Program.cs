using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2개의 정수(1 ~ 99)의 합을 맞추는 프로그램

namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            for (int i = 1; i <= 5; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(1, 100);
                int b = rnd.Next(1, 100);

                Console.WriteLine("{0}: 다음 두 수의 합은 몇? (총 5문제)", i);
                Console.WriteLine("{0} + {1} = ??", a, b);
                int answer = int.Parse(Console.ReadLine());

                if (answer == (a + b))
                {
                    Console.WriteLine("== 정답 ==");
                    Console.WriteLine();
                    y++;
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", a + b);
                    Console.WriteLine();
                }

            }

            Console.WriteLine("총 5문제 중 맞춘 문제는 {0}개", y);
        }
    }
}
