﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// try ~ catch ~ finally 키워드
// - 예외 상황과 관련 없이 무조건 처리

namespace _114_finally
{
    class Program
    {
        static void ThrowFunc(int data)
        {
            if (data > 0)
            {
                Console.WriteLine("ThrowFunc data: " + data);
            }
            else
            {
                throw new Exception("data에 0이 입력되었습니다.");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ThrowFunc(10);
                ThrowFunc(100);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("  finally 무조건 실행   \n"); // finally는 마지막에 한번만 실행됨 
            }

            try
            {
                ThrowFunc(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("  finally 무조건 실행   \n");
            }
        }
    }
}
