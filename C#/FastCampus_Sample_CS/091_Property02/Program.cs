using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로퍼티

namespace _091_Property02
{
    class AA
    {
        private int num;
        private string name;

        public int NUM { get; set; }    // 자동으로 게터, 세터 설정됨
        public string NAME { get; set; } = "NoName";    // 기본값 설정
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            Console.WriteLine("aa.NUM: {0}", aa.NUM);
            Console.WriteLine("aa.NAME: {0}", aa.NAME);

            aa.NUM = 100;
            Console.WriteLine("aa.NUM: {0}", aa.NUM);
            aa.NAME = "Jack";
            Console.WriteLine("aa.NAME: {0}", aa.NAME);
        }
    }
}
