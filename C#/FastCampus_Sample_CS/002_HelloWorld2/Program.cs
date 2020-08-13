using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 솔루션 -> 추가 -> 새 프로젝트
// 빌드 시 시작 프로젝트로 설정 필수
namespace _002_HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("HelloWorld:  " + args[0]);
            }
            else
            {
                Console.WriteLine("HelloWorld:  args.Length = 0");
            }
            // 프로젝트 파일 -> bin -> Debug 경로 복사
            // cmd 창에서 경로 이동하고 .exe 파일에 args 넣어서 실행해보기
        }
    }
}
