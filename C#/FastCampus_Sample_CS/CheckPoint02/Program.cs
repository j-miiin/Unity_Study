﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// 기존 프로젝트를 함수로 변경하기
// 숫자 달리기 게임 

namespace CheckPoint02
{
    class Program
    {
        const string LINE = "--------------------------------------------";
        const int END_LINE = 42;
        const int DELAY_TIME = 200;

        static int runA = 0;
        static int runB = 0;
        static int runC = 0;
        static int runD = 0;

        static void ClearScreen()
        {
            Thread.Sleep(DELAY_TIME); // 딜레이를 줌
            Console.Clear();    // 화면 지우기
        }
        static void Process(Random rnd)
        {
            ++runA;
            ++runB;
            ++runC;
            ++runD;

            int rndNum = rnd.Next(0, 4); // 0 ~ 3

            switch (rndNum)
            {
                case 0:
                    ++runA;
                    break;
                case 1:
                    ++runB;
                    break;
                case 2:
                    ++runC;
                    break;
                case 3:
                    ++runD;
                    break;
            }
        }
        static void UpdateScreen()
        {
            Console.WriteLine(LINE);

            for (int i = 0; i < runA; i++)
            {
                Console.Write(" ");
            }
            Console.Write("1");
            for (int i = END_LINE - runA; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            for (int i = 0; i < runB; i++)
            {
                Console.Write(" ");
            }
            Console.Write("2");
            for (int i = END_LINE - runB; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            for (int i = 0; i < runC; i++)
            {
                Console.Write(" ");
            }
            Console.Write("3");
            for (int i = END_LINE - runC; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            for (int i = 0; i < runD; i++)
            {
                Console.Write(" ");
            }
            Console.Write("4");
            for (int i = END_LINE - runD; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            Console.WriteLine(LINE);
        }
        static bool CheckResult()
        {
            if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
            {
                int runNum = 0;
                string strResult = "결과 :    !! {0}번 선수 우승 !!";

                if (runA >= END_LINE)
                {
                    runNum = 1;
                }
                else if (runB >= END_LINE)
                {
                    runNum = 2;
                }
                else if (runC >= END_LINE)
                {
                    runNum = 3;
                }
                else
                {
                    runNum = 4;
                }

                Console.WriteLine(strResult, runNum);

                Console.Write("다시하려면 0번 입력 : ");
                if ("0" == Console.ReadLine())
                {
                    runA = 0;
                    runB = 0;
                    runC = 0;
                    runD = 0;

                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                ClearScreen();

                Process(rnd);

                UpdateScreen();

                if (CheckResult() == false)
                    break;
            }
        }
    }
}
