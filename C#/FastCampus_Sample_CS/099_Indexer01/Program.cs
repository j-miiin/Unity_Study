using System;

// 인덱서
// - 배열 or 컬렉션의 외부 접근
// - 키워드 : get, set, return, value, this[int index]

namespace _099_Indexer01
{
    class AA
    {
        private int[] num = new int[10];

        public int this[int index]
        {
            get { return num[index]; }
            set { num[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();

            for(int i = 0; i < 10; i++)
            {
                aa[i] = i;  // 배열처럼 사용 가능 
            }

            aa[0] = 1000;
            aa[1] = 100;

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("aa[{0}]: {1}", i, aa[i]);
            }
        }
    }
}
