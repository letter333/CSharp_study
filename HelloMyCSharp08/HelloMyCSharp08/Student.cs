using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08
{
    public class Student<T>
    {
        public T hakbeon { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Student()
        {

        }

        public Student(T hakbeon, string name, int age)
        {
            this.hakbeon = hakbeon;
            this.name = name;
            this.age = age;
        }
    }
}
