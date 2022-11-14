using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_ps3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("안녕하세요 " + (i + 1) + "번님");
            }


            int sum = 0;
            for(int i = 1; i < 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("총 합 : " + sum);

            Console.WriteLine("숫자 입력");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
