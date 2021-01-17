using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// System.Exception
// - 예외 클래스의 Base

namespace _112_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 10;

            try
            {
                checked
                {
                    maxNum += Int32.MaxValue;   // 체크만 하고 이 값은 적용 안됨
                }
            }
            catch(OverflowException e)  // 이 catch문이 아래 catch문 밑으로 가면 오류가 남 -> 이미 위에서 모든 오류를 다 잡게 되기 때문
            {
                Console.WriteLine("e.Message: " + e.Message);
                Console.WriteLine("e.Source: " + e.Source);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("maxNum: " + maxNum);
        }
    }
}
