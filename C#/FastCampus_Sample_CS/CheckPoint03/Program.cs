using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 숫자 달리기 배열 적용

namespace CheckPoint03
{
    class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }
        }
        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }
        static void UpdateGO(int[] _arrIndex, int[,] _map)
        {
            for (int i = 0; i < _arrIndex.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = _arrIndex[i];

                int temp = _map[indexMaxX, indexY];
                _map[indexMaxX, indexY + 1] = temp;
                _map[indexMaxX, indexY] = 0;

                _arrIndex[i]++;
            }
        }

        static bool UpdateRandomG0(int[] _arrIndexX, int[,] _map, Random _rnd)
        {
            bool isFinish = false;

            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    return isFinish;
                }
            }

            int rndInedx = _rnd.Next(0, 5); // 0~4까지 생김
            int indexY = _arrIndexX[rndInedx];

            int temp = _map[rndInedx + 1, indexY];
            _map[rndInedx + 1, indexY + 1] = temp;
            _map[rndInedx + 1, indexY] = 0;

            _arrIndexX[rndInedx]++;

            return isFinish;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            // 타일 index   0     1    2    3   4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
                //0 1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21 
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },    // 0
                {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 },    // 1
                {4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 },    // 2
                {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 },    // 3
                {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 },    // 4
                {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 },    // 5
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }     // 6
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (true)
            {
                UpdateGO(arrIndexX, map);

                isFinish = UpdateRandomG0(arrIndexX, map, rnd);

                UpdateView(tile, map);

                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과 => 1등: {0}번", i + 1);
                            break;
                        }
                    }
                    Console.Write("\n다시 시작하려면 0을 입력");
                    string inputStr = Console.ReadLine();

                    if(inputStr == "0") {
                        for (int i = 1; i < 6; i++)
                        {
                            map[i, arrIndexX[i - 1]] = 0;
                        }

                        for (int i = 0; i < arrIndexX.Length; i++)
                        {
                            arrIndexX[i] = 0;
                        }

                        for (int i = 1; i < 6; i++)
                        {
                            map[i, 20] = 2;
                            map[i, 0] = i + 2;
                        }
                    }
                    else
                        break;
                }

                ClearView();
            }   
        }
    }
}
