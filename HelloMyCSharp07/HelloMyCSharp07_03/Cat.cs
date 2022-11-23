using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_03
{
    public class Cat : Animal
    {
        public override void eat()
        {
            System.Windows.Forms.MessageBox.Show($"{Name}고양이는 {Age}살 답게 잘 먹는다.");
        }
    }
}
