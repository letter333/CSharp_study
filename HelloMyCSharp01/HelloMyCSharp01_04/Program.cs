using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("안녕하세요 " + i + "번님");
            }

            while(true)
            {
                Console.WriteLine("숫자 입력ㄹ");
                int num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    Console.WriteLine("음수이므로 종료");
                    break;
                }
            }
        }
    }
}
