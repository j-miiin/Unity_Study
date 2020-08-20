using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// cast 연산자 기초

namespace _024_Data_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = (double)num;
            Console.WriteLine("num: {0}, dNum: {1}", num, dNum);

            double dNum2 = 12345678912;
            int num2 = (int)dNum2;
            Console.WriteLine("dNum: {0}, num2: {1}", dNum2, num2);
            // 큰거 -> 작은거 !주의!
        }
    }
}
