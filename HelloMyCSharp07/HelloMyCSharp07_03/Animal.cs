using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_03
{
    abstract public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void sleep()
        {
            System.Windows.Forms.MessageBox.Show($"{Name}은 {Age}살 이라서 많이 잡니다.");
        }

        public abstract void eat();
    }
}
