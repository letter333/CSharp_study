using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_03
{
    internal class Rabbit : Animal
    {
        public override void eat()
        {
            System.Windows.Forms.MessageBox.Show("토끼가 풀을 뜯어 먹는다");
        }
    }
}
