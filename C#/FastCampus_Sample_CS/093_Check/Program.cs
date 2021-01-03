using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 075_Check를 클래스로 변경

namespace _093_Check
{
    class Student
    {
        int[] ID = new int[3];
        int[] kor = new int[3];
        int[] math = new int[3];
        int[] eng = new int[3];

        public Student()
        {
            Array.Clear(ID, 0, ID.Length);
            Array.Clear(kor, 0, kor.Length);
            Array.Clear(math, 0, math.Length);
            Array.Clear(eng, 0, eng.Length);
        }

        public void InputID(int index)
        {
            Console.Write("학생 ID를 입력하세요 ");
            ID[index] = int.Parse(Console.ReadLine());
        }

        public void InputKor(int index)
        {
            Console.Write("국어 점수를 입력하세요 ");
            kor[index] = int.Parse(Console.ReadLine());
        }

        public void InputMath(int index)
        {
            Console.Write("수학 점수를 입력하세요 ");
            math[index] = int.Parse(Console.ReadLine());
        }

        public void InputEng(int index)
        {
            Console.Write("영어 점수를 입력하세요 ");
            eng[index] = int.Parse(Console.ReadLine());
        }

        public void PrintID(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("학생 ID: " + ID[i]);
            }
        }

        public int CheckID(int id, int max)
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

        public void PrintInfo(int id)
        {
            Console.WriteLine("국어 점수: " + kor[id]);
            Console.WriteLine("수학 점수: " + math[id]);
            Console.WriteLine("영어 점수: " + eng[id]);
            int sum = kor[id] + math[id] + eng[id];
            float avg = sum / 3f;
            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avg);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            int index, id, choice;

            for (index = 0; index < 3; index++)
            {
                std.InputID(index);
                std.InputKor(index);
                std.InputMath(index);
                std.InputEng(index);
                Console.WriteLine();
            }

            while (true)
            {
                std.PrintID(index);
                Console.Write("학생 아이디를 입력하세요 (0은 나가기)");
                id = int.Parse(Console.ReadLine());

                if (id == 0)
                    break;

                choice = std.CheckID(id, index);
                if (choice == -1)
                {
                    Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                }
                else
                {
                    std.PrintInfo(choice);
                }
            }
        }
    }
}
