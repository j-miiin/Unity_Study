using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열 관리 방법
// Clear, Length, GetLength, Clone(Clone은 object형 리턴이라서 캐스팅 필요, call by value임)

namespace _074_Array_Clear
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            Array.Clear(array, 0, array.Length);
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("   {0}", array[i]);
            }

            Console.WriteLine("\n--------------------------------");

            int[,] arrNum = new int[3, 2];

            Console.WriteLine("\n----- Array.Clear -----");
            Array.Clear(arrNum, 0, arrNum.Length);

            for (int i = 0; i < arrNum.GetLength(0); i++)   // arrNum.GetLength(0) => 3
            {
                for(int j = 0; j < arrNum.GetLength(1); j++)    // arrNum.GetLength(1) => 2
                {
                    arrNum[i, j] = (i * arrNum.GetLength(1)) + j;
                }
            }

            for (int i = 0; i < arrNum.GetLength(0); i++)
            {
                for (int j = 0; j < arrNum.GetLength(1); j++)
                {
                    Console.Write("   " + arrNum[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--------------------------------");

            int[,,] arrMulti1 = new int[,,]
            {
                {{0, 1 }, {2, 3 }, {4, 5 } },
                {{6, 7 }, {8, 9 }, {10, 11 } },
                {{12, 13 }, {14, 15 }, {16, 17 } },
                {{18, 19 }, {20, 21 }, {22, 23 } }
               };

            Console.WriteLine("arrMulti1.Length: " + arrMulti1.Length);

            for (int i = 0; i < arrMulti1.GetLength(0); i++)
            {
                for (int j = 0; j < arrMulti1.GetLength(1); j++)
                {
                    for (int k = 0; k < arrMulti1.GetLength(2); k++)
                    {
                        Console.Write("   " + arrMulti1[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--------------------------------");

            int[,,] cloneArray = (int[,,])arrMulti1.Clone();    // 캐스팅 연산자 필요

            for (int i = 0; i < cloneArray.GetLength(0); i++)
            {
                for (int j = 0; j < cloneArray.GetLength(1); j++)
                {
                    for (int k = 0; k < cloneArray.GetLength(2); k++)
                    {
                        Console.Write("   " + cloneArray[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--------------------------------");
            cloneArray[0, 0, 0] = 10000;
            Console.Write("\n arrMulti[0, 0, 0]:   {0}", arrMulti1[0, 0, 0]);
            Console.Write("\n cloneArray[0, 0, 0]:   {0}", cloneArray[0, 0, 0]);
        }
    }
}
