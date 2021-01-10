using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 094_Check를 입력 제한 없이 처리

namespace _102_Check
{
    class Num
    {
        int a;
        int b;

        public Num()
        {
            a = 0;
            b = 0;
        }

        public void InputNumber(int count)
        {
            if (count == 1)
            {
                Console.Write("첫번째 수를 입력해 주세요 ");
                a = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("두번째 수를 입력해 주세요 ");
                b = int.Parse(Console.ReadLine());
            }
        }

        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }
    }
    class Program
    {
        static void PrintResult(Hashtable hash, int index)
        {
            Num num = new Num();
            num = (Num)hash[index];

            Console.WriteLine("{0} + {1} = {2}", num.getA(), num.getB(), num.getA() + num.getB());
        }

        static bool CheckEnd()
        {
            int c;

            Console.Write("추가로 계산할까요? (1: OK, 0: NO, 단 총 10번까지 가능)");
            c = int.Parse(Console.ReadLine());

            if (c == 1)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Hashtable numHash = new Hashtable();
            // ArrayList로 해도 됨 
            int index = 0;

            while (true)
            {
                Num num = new Num();
                num.InputNumber(1);
                num.InputNumber(2);
                numHash.Add(index, num);
                PrintResult(numHash, index);

                index++;

                if (CheckEnd() == false)
                {
                    for (int i = 0; i < index; i++)
                    {
                        PrintResult(numHash, i);
                    }
                    break;
                }
            }
        }
    }
}
