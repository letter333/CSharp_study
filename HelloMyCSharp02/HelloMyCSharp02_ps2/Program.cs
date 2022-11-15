using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_ps2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "오세룡";
            s1.Age = 25;
            s1.eye = 0.01;

            Student s2 = new Student();
            Console.WriteLine("s2 학생이름");
            s2.Name = Console.ReadLine();
            Console.WriteLine("s2 학생나이");
            s2.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("s2 학생시력");
            s2.eye = double.Parse(Console.ReadLine());

            Student[] students = new Student[3];
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("학생 이름");
                students[i].Name = Console.ReadLine();
                Console.WriteLine("학생 나이");
                students[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("학생 시력");
                students[i].eye = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(s1.Name + "/" + s1.Age + "/" + s1.eye);
            Console.WriteLine(s2.Name + "/" + s2.Age + "/" + s2.eye);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Name + "/" + students[i].Age + "/" + students[i].eye);
            }

            KBStudent[] kbstudents = new KBStudent[3];
            for(int i = 0; i < kbstudents.Length; i++)
            {
                Console.WriteLine("학생 이름");
                kbstudents[i].Name = Console.ReadLine();
                Console.WriteLine("학생 나이");
                kbstudents[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("학생 시력");
                kbstudents[i].eye = double.Parse(Console.ReadLine());
                Console.WriteLine("학생 MBTI");
                kbstudents[i].MBTI = Console.ReadLine();
            }

            for(int i = 0; i < kbstudents.Length; i++)
            {
                Console.WriteLine(kbstudents[i].Name + "/" + kbstudents[i].Age + "/" + kbstudents[i].eye + "/" + kbstudents[i].MBTI);
            }
        }
    }
}
