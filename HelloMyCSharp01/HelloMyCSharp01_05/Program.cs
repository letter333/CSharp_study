using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("짝수");
                }
                Console.WriteLine("i = " + i);
            }

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
                if(i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine("짝수");
            }

        }
    }
}
