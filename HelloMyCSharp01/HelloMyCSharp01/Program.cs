using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI");

            int num1 = 10;
            double num2 = 3.14;
            string m1 = "Hello";
            String m2 = "이것도 됨";
            char lastName = '이';
            bool tf = true;
            Boolean tf2 = false;
            char c1 = "안녕하세요"[0];
            string s1 = "hello";
            char c2 = s1[1];

            Console.WriteLine(c1);
            Console.WriteLine(s1);
            Console.WriteLine(c2);

            Console.WriteLine(10 + 20);
            Console.WriteLine("안녕" + "하세요");
            Console.WriteLine("10" + 20);

            int age = 25;
            string info = "내 나이 : " + age;
            Console.WriteLine(info);

            string info2 = string.Format("내 나이 : {0}", age);
            Console.WriteLine(info2);

            string info3 = $"내 나이 : {age}";
            Console.WriteLine(info3);
        }
    }
}
