using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5명의 성적 점수(정수)를 입력받아 가장 높은 점수와 가장 낮은 점수 출력

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 0; // int maxNum = int.MinValue;
            int minNum = 100;   // int minNum = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요 : ");
                int grade = int.Parse(Console.ReadLine());

                if (grade > maxNum)
                {
                    maxNum = grade;
                }
                if (grade <= minNum)
                {
                    minNum = grade;
                }
            }

            Console.WriteLine("최대값: {0}    최소값: {1}", maxNum, minNum);
        }
    }
}
