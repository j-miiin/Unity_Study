using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외 처리 제외
// 두 수를 입력 받아 더하기 연산을 10번까지 저장 가능한 프로그램
// 반드시 배열을 사용해서 연산 저장
// 연산을 끝내고 나갈 때 기존 연산 자료를 한번에 보여주기

namespace _076_Check
{
    class Program
    {
        static int InputNumber(int count)
        {
            if (count == 1)
            {
                Console.Write("첫번째 수를 입력해 주세요 ");
                return int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("두번째 수를 입력해 주세요 ");
                return int.Parse(Console.ReadLine());
            }
        }
        static void PrintResult(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static bool CheckEnd()
        {
            int a;

            Console.Write("추가로 계산할까요? (1: OK, 0: NO, 단 총 10번까지 가능)");
            a = int.Parse(Console.ReadLine());

            if (a == 1)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int[] result = new int[10];
            int[] a = new int[10];
            int[] b = new int[10];
            int index = 0;

            Array.Clear(result, 0, result.Length);
            Array.Clear(a, 0, a.Length);
            Array.Clear(b, 0, b.Length);

            while (true)
            {
                a[index] = InputNumber(1);
                b[index] = InputNumber(2);
                result[index] = a[index] + b[index];

                PrintResult(a[index], b[index]);
                index++;

                if (CheckEnd() == false)
                    break;
            }
            
            for(int i = 0; i < index; i++)
            {
                Console.WriteLine("{0} + {1} = {2}", a[i], b[i], result[i]);
            }
        }
    }
}
