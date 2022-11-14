using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_ps4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1부터 10까지 순차적으로 출력 for");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("1부터 10까지 순차적으로 출력 while");
            int num = 1;
            while(num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("a부터 b까지 순차적으로 출력 for");
            Console.WriteLine("a, b입력");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            for(int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("a부터 b까지 순차적으로 출력 while");
            Console.WriteLine("a, b입력");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            num = a;
            while(num <= b)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("1부터 100까지 출력하되, 짝수만 출력 for");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("1부터 100까지 출력하되, 짝수만 출력 while");
            num = 1;
            while(num <= 100)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }

            Console.WriteLine("a랑 b를 입력하되, b부터 a까지 역순 출력 for");
            Console.WriteLine("a, b입력");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            for(int i = b; i >= a; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("a랑 b를 입력하되, b부터 a까지 역순 출력 while");
            Console.WriteLine("a, b입력");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            num = b;
            while(num >= a)
            {
                Console.WriteLine(num);
                num--;
            }
        }
    }
}
