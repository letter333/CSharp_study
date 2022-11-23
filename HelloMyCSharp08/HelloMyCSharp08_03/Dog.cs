using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_03
{
    public class Dog : ICharming
    {
        public string name { get; set; }
        public int age { get; set; }

        public void actCute()
        {
            System.Windows.Forms.MessageBox.Show("주인을 핥는다.");
        }

        public void smile()
        {
            System.Windows.Forms.MessageBox.Show("헤헤헤헤");
        }

        public void welcome()
        {
            System.Windows.Forms.MessageBox.Show("꼬리를 흔든다.");
        }
    }
}
