﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// char형(작은 따옴표), string형 기초(쌍 따옴표)

namespace _014_Data7
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'H';
            char b = 'e';
            char c = 'l';
            char d = 'l';
            char e = 'o';

            string str = "World!";

            Console.WriteLine("{0}{1}{2}{3}{4} {5}", a, b, c, d, e, str);
        }
    }
}
