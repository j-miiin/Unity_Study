using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 함수의 매개변수로 배열 이용
// call by reference

namespace _072_Array_Func1
{
    class Program
    {
        static void SwapArray(int oriIndex, int desIndex, int[] array)
        {
            int temp = array[oriIndex];
            array[oriIndex] = array[desIndex];
            array[desIndex] = temp;
        }

        static void Main(string[] args)
        {
            int[] arrNum = new int[] { 1, 2, 3, 4 };

            foreach(int temp in arrNum)
            {
                Console.WriteLine("   {0}", temp);
            }

            SwapArray(0, 1, arrNum);

            Console.WriteLine("");

            foreach(int temp in arrNum)
            {
                Console.WriteLine("   {0}", temp);
            }
        }
    }
}
