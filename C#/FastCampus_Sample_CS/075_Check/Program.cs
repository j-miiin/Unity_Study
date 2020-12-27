using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외 처리는 제외
// 성적 프로그램을 3명까지만 저장하고 정보 검색이 가능한 프로그램
// 배열을 사용해서 데이터 저장
// 저장했던 자료에서 참고하고 싶은 학생번호로 정보 보여주기

namespace _075_Check
{
    class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요 ");
            ID[index] = int.Parse(Console.ReadLine());
        }
        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요 ");
            kor[index] = int.Parse(Console.ReadLine());
        }
        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요 ");
            math[index] = int.Parse(Console.ReadLine());
        }
        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요 ");
            eng[index] = int.Parse(Console.ReadLine());
        }
        static void PrintID(int max, int[] ID)
        {
            for(int i = 0; i < max; i++)
            {
                Console.WriteLine("학생 ID: " + ID[i]);
            }
        }
        static int CheckID(int id, int max, int[] ID)
        {
            for (int i = 0; i < max; i++)
            {
                if (ID[i] == id)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int index, id, choice;
            int[] ID = new int[10];
            int[] kor = new int[10];
            int[] math = new int[10];
            int[] eng = new int[10];

            Array.Clear(ID, 0, ID.Length);
            Array.Clear(kor, 0, kor.Length);
            Array.Clear(math, 0, math.Length);
            Array.Clear(eng, 0, eng.Length);

            for (index = 0; index < 3; index++)
            {
                InputID(ID, index);
                InputKor(kor, index);
                InputMath(math, index);
                InputEng(eng, index);
                Console.WriteLine();
            }

            while(true)
            {
                PrintID(index, ID);
                Console.Write("학생 아이디를 입력하세요 (0은 나가기)");
                id = int.Parse(Console.ReadLine());

                if (id == 0)
                    break;

                choice = CheckID(id, index, ID);
                if (choice == -1)
                {
                    Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                }
                else
                {
                    Console.WriteLine("국어 점수: " + kor[choice]);
                    Console.WriteLine("수학 점수: " + math[choice]);
                    Console.WriteLine("영어 점수: " + eng[choice]);
                    int sum = kor[choice] + math[choice] + eng[choice];
                    float avg = sum / 3f;
                    Console.WriteLine("총점: " + sum);
                    Console.WriteLine("평균: " + avg);
                    Console.WriteLine();
                }
            }
        }
    }
}
