using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------1------");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("------2------");
            Console.WriteLine("10 + 20 = " + (10 + 20));
            Console.WriteLine("7 / 3 = " + (7 / 3));
            Console.WriteLine("7 % 3 = " + (7 % 3));
            Console.WriteLine("7 - 3 = " + (7 - 3));
            Console.WriteLine("10 * 20 = " + (10 * 20));
            Console.WriteLine("------3------");
            Console.WriteLine("\"10\" + 10" + ("10" + 10));
            Console.WriteLine("\'2\' + 100"  + ('2' + 100));
            Console.WriteLine("\"10\" + \'2\'" + "10" + '2');
            Console.WriteLine("------4------");
            Console.WriteLine("몇년생?");
            int mybirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"나는 {mybirth}년생입니다.");
            Console.WriteLine("------5------");
            Console.WriteLine("이름?");
            string myname = Console.ReadLine();
            Console.WriteLine($"내 이름은 {myname}입니다.");
            Console.WriteLine("------6------");
            int age = 20;
            string name = "오세룡";
            Console.WriteLine($"나는 \"{name}\"입니다. 나이는 \"{age}\"대입니다.");
            Console.WriteLine("------7------");
            Console.WriteLine("나이?");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.Year - myage + 1 + "년생");
            Console.WriteLine("------8------");
            Console.WriteLine("현재 몇년?");
            int nowYear = int.Parse(Console.ReadLine());
            Console.WriteLine("몇년생?");
            int bornYear = int.Parse(Console.ReadLine());
            Console.WriteLine(nowYear - bornYear + 1 + "살");
            Console.WriteLine("------9------");
            Console.WriteLine("글자 입력");
            string str = Console.ReadLine();
            Console.WriteLine(str[0]);
            Console.WriteLine("------10------");
            Console.WriteLine("변 길이?");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("정사각형의 넓이 : " + (w * w));
            Console.WriteLine("------11------");
            Console.WriteLine("숫자 입력");
            int num = int.Parse(Console.ReadLine());
            if(num < 0)
            {
                Console.WriteLine("음수");
            } else
            {
                Console.WriteLine("음수 아님");
            }
            Console.WriteLine("------12------");
            if(num > 0)
            {
                Console.WriteLine("자연수");
            } else
            {
                Console.WriteLine("자연수 아님");
            }
            Console.WriteLine("------13------");
            Random r = new Random();
            switch(r.Next(3))
            {
                case 0:
                    Console.WriteLine("가위");
                    break;
                case 1:
                    Console.WriteLine("바위");
                    break;
                case 2:
                    Console.WriteLine("보");
                    break;
                default:
                    Console.WriteLine("뭔가 잘못됨");
                    break;
            }
            Console.WriteLine("------14------");
            Console.WriteLine("가위바위보 입력(0, 1, 2)");
            int comrsp = r.Next(3);
            int myrsp = int.Parse(Console.ReadLine());
            switch(myrsp)
            {
                case 0: 
                    switch(comrsp)
                    {
                        case 0:
                            Console.WriteLine("무승부");
                            break;
                        case 1:
                            Console.WriteLine("패");
                            break;
                        case 2:
                            Console.WriteLine("승");
                            break;
                        default:
                            Console.WriteLine("뭔가 잘못됨");
                            break;
                    }
                    break;
                case 1:
                    switch (comrsp)
                    {
                        case 0:
                            Console.WriteLine("승");
                            break;
                        case 1:
                            Console.WriteLine("무승부");
                            break;
                        case 2:
                            Console.WriteLine("패");
                            break;
                        default:
                            Console.WriteLine("뭔가 잘못됨");
                            break;
                    }
                    break;
                case 2:
                    switch (comrsp)
                    {
                        case 0:
                            Console.WriteLine("패");
                            break;
                        case 1:
                            Console.WriteLine("승");
                            break;
                        case 2:
                            Console.WriteLine("무승부");
                            break;
                        default:
                            Console.WriteLine("뭔가 잘못됨");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("잘못 입력함");
                    break;
            }
            Console.WriteLine("------15------");
            if (myrsp == comrsp)
            {
                Console.WriteLine("무승부");
            }
            else if (myrsp == 0 && comrsp == 1)
            {
                Console.WriteLine("패");
            }
            else if (myrsp == 0 && comrsp == 2)
            {
                Console.WriteLine("승");
            }
            else if (myrsp == 1 && comrsp == 0)
            {
                Console.WriteLine("승");
            }
            else if (myrsp == 1 && comrsp == 2)
            {
                Console.WriteLine("패");
            }
            else if(myrsp == 2 && comrsp == 0)
            {
                Console.WriteLine("패");
            } else if(myrsp == 2 && comrsp == 1)
            {
                Console.WriteLine("승");
            } else
            {
                Console.WriteLine("잘못 입력함");
            }
            Console.WriteLine("------16------");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------17------");
            int mul = 1;
            for(int i = 1; i <= 10; i++)
            {
                mul *= i;
            }
            Console.WriteLine("1부터 10까지 곱한 값 : " + mul);
            Console.WriteLine("------18------");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"안녕하세요 {i}번째 손님");
            }
            Console.WriteLine("------19------");
            Console.WriteLine("숫자 입력");
            while(true)
            {
                int input = int.Parse(Console.ReadLine());
                if(input == 0)
                {
                    break;
                }
                Console.WriteLine(input * input);
            }
            Console.WriteLine("------20-1------");
            mul = 1;
            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                mul *= i;
            }
            Console.WriteLine("1부터 10까지 홀수 값의 곱(continue사용) : " + mul);
            Console.WriteLine("------20-2------");
            mul = 1;
            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 == 1)
                {
                    mul *= i;
                }
            }
            Console.WriteLine("1부터 10까지 홀수 값의 곱(continue 사용x)" + mul);
        }
    }
}
