﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 산술연산자 : ++, --

namespace _036_Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num: {0}", num++);   // 후치 연산
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", ++num);   // 전치 연산

            Console.WriteLine("num: {0}", num--);   // 후치 연산
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", --num);   // 전치 연산
        }
    }
}
