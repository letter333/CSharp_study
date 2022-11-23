using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_ps
{
    public class MyParent
    {
        public static int money;

        public static void openDoor()
        {
            Console.WriteLine("문 열어라");
        }

        public string name { get; set; }
        public int age { get; set; }

        public void eat()
        {
            Console.WriteLine("밥을 먹어요" + name);
        }
        public void sleep()
        {
            Console.WriteLine(age + "살에 맞게 잘 자요");
        }
    }
}
