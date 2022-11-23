using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_ps
{
    public class MyChild : MyParent
    {
        public MyChild()
        {
            money--;
        }

        public void study()
        {
            Console.WriteLine("공부");
        }

        public void playGame()
        {
            Console.WriteLine("게임");
        }
    }
}
