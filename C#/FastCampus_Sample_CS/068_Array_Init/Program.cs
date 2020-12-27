using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일차열 배열 선언과 초기화

namespace _068_Array_Init
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[3];
            // int[] arrNum = new int[]{0, 1, 2};
            // int[] arrNum = new int[3]{0, 1, 2};
            // int[] arrNum = {0, 1, 2};

            arrNum[0] = 1;
            arrNum[1] = 2;
            arrNum[2] = 3;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("  {0}", arrNum[i]);
            }

            Console.WriteLine("\n arrNum.GetType():   {0}", arrNum.GetType());
        }
    }
}
