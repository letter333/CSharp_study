using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_ps2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("삼항연산자");

            string result = num == 0 ? "0" : (num > 0 ? "양" : "음");
            Console.WriteLine(result);

            Console.WriteLine("if문");
            if (num == 0)
            {
                Console.WriteLine(0);
            }
            else if (num > 0)
            {
                Console.WriteLine("양");
            }
            else
            {
                Console.WriteLine("음");
            }

            Console.WriteLine("주사위 몇?");
            int d1 = int.Parse(Console.ReadLine());

            switch (d1)
            {
                case 1:
                    Console.WriteLine("일");
                    break;
                case 2:
                    Console.WriteLine("이");
                    break;
                case 3:
                    Console.WriteLine("삼");
                    break;
                case 4:
                    Console.WriteLine("사");
                    break;
                case 5:
                    Console.WriteLine("오");
                    break;
                case 6:
                    Console.WriteLine("육");
                    break;
            }

            Console.WriteLine("컴퓨터가 입력");
            Random random = new Random();
            int d2 = random.Next(6) + 1;

            switch (d2)
            {
                case 1:
                    Console.WriteLine("일");
                    break;
                case 2:
                    Console.WriteLine("이");
                    break;
                case 3:
                    Console.WriteLine("삼");
                    break;
                case 4:
                    Console.WriteLine("사");
                    break;
                case 5:
                    Console.WriteLine("오");
                    break;
                case 6:
                    Console.WriteLine("육");
                    break;
            }         



            Console.WriteLine("나이 입력");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("무효");
            }
            else if (age < 20)
            {
                Console.WriteLine("미성년자");
            }
            else if (age < 150)
            {
                Console.WriteLine("성인");
            }
            else
            {
                Console.WriteLine("얜 뭐지?");
            }
        }
    }
}
