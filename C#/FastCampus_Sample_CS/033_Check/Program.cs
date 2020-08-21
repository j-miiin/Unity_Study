using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 간단한 성적 프로그램 만들기
// - 국어, 영어, 수학, 과학 4과목을 입력 받고, 총점과 평균 보여주기

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요 : ");
            string korean = Console.ReadLine();
            int a = int.Parse(korean);
            Console.Write("영어 점수를 입력하세요 : ");
            string english = Console.ReadLine();
            int b = int.Parse(english);
            Console.Write("수학 점수를 입력하세요 : ");
            string math = Console.ReadLine();
            int c = int.Parse(math);
            Console.Write("과학 점수를 입력하세요 : ");
            string science = Console.ReadLine();
            int d = int.Parse(science);
            // int d = int.Parse(Console.ReadLine());

            int sum = a + b + c + d;
            float avg = (float)sum / 4;
            // float avg = sum / 4f;

            Console.WriteLine("국어: {0}    영어: {1}    수학: {2}    과학: {3}", korean, english, math, science);
            Console.WriteLine("총점: {0}    평균: {1}", sum, avg);
        }
    }
}
