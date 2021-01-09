using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 컬렉션
// ArrayList
// - 배열과 비슷
// - 크기가 유동적(동적)
// ArrayList arrList = new ArrayList();

namespace _095_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello");   // 모든 데이터 받을 수 있음 
            arrList.Add(10f);

            for(int i = 0; i < 10; i++)
            {
                arrList.Add(i);
            }

            foreach(object data in arrList)
            {
                Console.WriteLine("arrList data: " + data);
            }

            // 배열 데이터로 초기화
            Console.WriteLine("배열 데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            ArrayList arrCopyList = new ArrayList(arrData);

            foreach(object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList data: " + data);
            }
        }
    }
}
