using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름?");
            string name = Console.ReadLine();
            Console.WriteLine("나이?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("몸무게?");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(kg);

            Console.WriteLine(DateTime.Now.Year);
        }
    }
}
