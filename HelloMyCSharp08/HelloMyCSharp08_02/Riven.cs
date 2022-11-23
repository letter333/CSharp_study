using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_02
{
    public class Riven : LoLCharacter
    {
        public override void QKey()
        {
            Console.WriteLine("리븐Q3번");
        }
        public override void WKey()
        {
            Console.WriteLine("리븐W");
        }
        public override void EKey()
        {
            Console.WriteLine("리븐E");
        }
        public override void RKey()
        {
            Console.WriteLine("리븐R");
        }

        public new void Attack()
        {
            Console.WriteLine("리븐 평타");
        }

        public override void sayHello()
        {
            Console.WriteLine("리븐 인사");
        }

        public new void MoveUp()
        {
            Console.WriteLine("위");
        }
        public new void MoveDown()
        {
            Console.WriteLine("아래");
        }
        public new void MoveLeft()
        {
            Console.WriteLine("왼쪽");
        }
        public new void MoveRight()
        {
            Console.WriteLine("오른쪽");
        }
    }
}
