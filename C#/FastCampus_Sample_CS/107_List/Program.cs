using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일반화 컬렉션(Collections Generic)
// - 컬렉션의 박싱과 언박싱 단점을 해결
// - List<T>
// - Queue<T>
// - Stack<T>
// - Dictionary<T>

namespace _107_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListAA = new List<int>();
            ListAA.Add(1);
            ListAA.Add(2);

            for(int i = 0; i < 10; i++)
            {
                ListAA.Add(i);
            }

            foreach(var data in ListAA)
            {
                Console.WriteLine("data: " + data);
            }

            Console.WriteLine("\n배열 데이터로 초기화");
            string[] arrData = { "AA", "BB", "CC" };
            List<string> listArr = new List<string>(arrData);

            for(int i = 0; i < arrData.Length; i++)
            {
                Console.WriteLine("arrData: " + arrData[i]);
            }
        }
    }
}
