using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 093_Check를 입력 제한 없이 처리
// ContainsKey() : Hashtable에 저장된 키 값이 있는지 체크

namespace _101_Check
{
    class Student
    {
        int ID;
        int kor;
        int math;
        int eng;

        public Student()
        {
            ID = 0;
            kor = 0;
            math = 0;
            eng = 0;
        }

        public void InputID()
        {
            Console.Write("학생 ID를 입력하세요 ");
            ID = int.Parse(Console.ReadLine());
        }

        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요 ");
            kor = int.Parse(Console.ReadLine());
        }

        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요 ");
            math = int.Parse(Console.ReadLine());
        }

        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요 ");
            eng = int.Parse(Console.ReadLine());
        }

        public int getID()
        {
            return ID;
        }

        public int getKor()
        {
            return kor;
        }

        public int getMath()
        {
            return math;
        }

        public int getEng()
        {
            return eng;
        }
    }
    class Program
    {
        static void PrintID(Hashtable hash)
        {
            foreach (object data in hash.Keys)
            {
                Console.WriteLine("학생 ID: " + data);
            }
        }

        static int CheckID(int id, Hashtable hash)
        {
            if (hash.ContainsKey(id))
            {
                return id;
            }

            return -1;
        }

        static void PrintInfo(int id, Hashtable hash)
        {
            Student std = new Student();
            std = (Student) hash[id];

            Console.WriteLine("국어 점수: " + std.getKor());
            Console.WriteLine("수학 점수: " + std.getMath());
            Console.WriteLine("영어 점수: " + std.getEng());
            int sum = std.getKor() + std.getMath() + std.getEng();
            float avg = sum / 3f;
            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avg);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Hashtable stdHash = new Hashtable();    
            int id, choice, index = 0;

            while (true)
            {
                if (index != 0)
                    PrintID(stdHash);

                Console.Write("== 성적 입력 중== (0) : 나가기    ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;
                else
                {
                    Student std = new Student();
                    std.InputID();
                    std.InputKor();
                    std.InputMath();
                    std.InputEng();
                    stdHash.Add(std.getID(), std);
                    Console.WriteLine();
                    index++;
                }
            }

            while (true)
            {
                PrintID(stdHash);
                Console.Write("학생 아이디를 입력하세요 (0은 나가기)");
                id = int.Parse(Console.ReadLine());

                if (id == 0)
                    break;

                if (CheckID(id, stdHash) == -1)
                {
                    Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                }
                else
                {
                    PrintInfo(id, stdHash);
                }
            }
        }
    }
}
