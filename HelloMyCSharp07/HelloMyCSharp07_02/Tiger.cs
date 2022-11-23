using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_02
{
    public class Tiger : Cat
    {
        // 하이딩 => 강제 형변환하면 부모 클래스의 메소드 호출됨
        public new void eat()
        {
            System.Windows.Forms.MessageBox.Show($"{name}호랑이는 무섭게 먹습니다.{age}살이에요.");
        }

        // 오버라이딩 => 강제 형변환해도 부모 클래스의 메소드 호출 X 
        public override void fight()
        {
            /*base.fight();*/
            System.Windows.Forms.MessageBox.Show($"{age}살 {name} 호랑이의 혈투");
        }

        //object에 있는 ToString()을 오버라이드 한 것
        public override string ToString()
        {
            return $"이름 : {name}, 나이 : {age}";
            //return base.ToString();
        }
    }
}
