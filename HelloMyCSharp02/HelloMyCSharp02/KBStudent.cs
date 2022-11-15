using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02
{
    public struct KBStudent
    {
        public string Name;
        public double Eye;
        public int Age;
        public string MBTI;

        public void introduce()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("시력 : " + Eye);
            Console.WriteLine("나이 : " + Age);
            Console.WriteLine("MBTI : " + MBTI);
        }
    }
}
