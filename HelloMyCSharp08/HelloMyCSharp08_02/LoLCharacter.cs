using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_02
{
    public class LoLCharacter : GameCharacter, IRpgCharacter, IRts
    {
        public int level { get; set; }

        public virtual void QKey() { Console.WriteLine("Q키 누름"); }
        public virtual void WKey() { Console.WriteLine("W키 누름"); }
        public virtual void EKey() { Console.WriteLine("E키 누름"); }
        public virtual void RKey() { Console.WriteLine("R키 누름"); }

        public void Attack()
        {
            QKey();
            WKey();
            EKey();
            RKey();
        }

        public void MoveDown()
        {
            Console.WriteLine("아래로 간다.");
        }

        public void MoveLeft()
        {
            Console.WriteLine("왼쪽으로 간다.");
        }

        public void MoveRight()
        {
            Console.WriteLine("오른쪽으로 간다.");
        }

        public void MoveUp()
        {
            Console.WriteLine("위로 간다.");
        }

        public override void sayHello()
        {
            Console.WriteLine("인사를 한다.");
        }
    }
}
