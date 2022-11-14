using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("------------1------------");
            Console.WriteLine("안녕, 내 이름은 오세룡이고, 남자이며, 20대야");
            Console.WriteLine("------------2------------");
            int age = 25;
            string name = "오세룡";

            Console.WriteLine("안녕 나는 " + age + "살 남성이고, " + name + "이라고 해.");
            Console.WriteLine(string.Format("안녕 나는 {0}살 남성이고, {1}이라고 해", age, name));
            Console.WriteLine($"안녕 나는 {age}살 남성이고, {name}이라고 해.");*/
            Console.WriteLine("나이?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("이름?");
            string name = Console.ReadLine();
            Console.WriteLine("MBTI?");
            string mbti = Console.ReadLine();
            Console.WriteLine("혈액형?");
            string bt = Console.ReadLine();
            Console.WriteLine($"나이 : {age}, 이름 : {name}, MBTI : {mbti}, 혈액형 : {bt}");

            Console.WriteLine("몇년생?");
            int year = int.Parse(Console.ReadLine());
            int myAge = DateTime.Now.Year + 1 - year;
            Console.WriteLine($"내 나이는 {myAge}살");

            Console.WriteLine("반지름?");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("원의 둘레 : " + 2 * 3.14 * r);
            Console.WriteLine("원의 넓이 : " + r * r * 3.14);

            Console.WriteLine("시력?");
            double eye = double.Parse(Console.ReadLine());
            Console.WriteLine($"내 시력 : {eye}");
        }
    }
}
