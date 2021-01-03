using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 076_Check를 클래스로 변경

namespace _094_Check
{
    class Num
    {
        int[] a = new int[10];
        int[] b = new int[10];

        public Num()
        {
            Array.Clear(a, 0, a.Length);
            Array.Clear(b, 0, b.Length);
        }

        public void InputNumber(int index, int count)
        {
            if (count == 1)
            {
                Console.Write("첫번째 수를 입력해 주세요 ");
                a[index] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("두번째 수를 입력해 주세요 ");
                b[index] = int.Parse(Console.ReadLine());
            }
        }

        public void PrintResult(int index)
        {
            Console.WriteLine("{0} + {1} = {2}", a[index], b[index], a[index] + b[index]);
        }

        public bool CheckEnd()
        {
            int c;

            Console.Write("추가로 계산할까요? (1: OK, 0: NO, 단 총 10번까지 가능)");
            c = int.Parse(Console.ReadLine());

            if (c == 1)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Num num = new Num();
            int index = 0;

            while (true)
            {
                num.InputNumber(index, 1);
                num.InputNumber(index, 2);

                num.PrintResult(index);
                index++;

                if (index >= 10 || num.CheckEnd() == false)
                {
                    for (int i = 0; i < index; i++)
                    {
                        num.PrintResult(i);
                    }
                    break;
                }
            }
        }
    }
}
