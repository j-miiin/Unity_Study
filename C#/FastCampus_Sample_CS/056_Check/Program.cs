using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 랜덤한 정수(1 ~ 99)를 맞추는 프로그램

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            int tryNum = 0;

            while (true)
            {
                Console.WriteLine("1 ~ 99 사이 어떤 숫자일까요? (단, 0은 나가기)");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                if (tryNum > 10)
                {
                    Console.WriteLine("기회를 다 사용했습니다. 정답은 {0}이었습니다.", answer);
                    break;
                }

                if (num > answer)
                {
                    Console.WriteLine("입력한 수보다 작아요");
                    ++tryNum;
                }
                else if (num < answer)
                {
                    Console.WriteLine("입력한 수보다 커요");
                    ++tryNum;
                }
                else
                {
                    Console.WriteLine("=== 정답입니다. ===");
                    ++tryNum;
                    Console.WriteLine("총 {0}번 시도", tryNum);
                    break;
                }
            }
        }
    }
}
