using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat c = new Cat() { age = 10, name = "야용이" };
            c.eat();
            c.sleep();
            c.fight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tiger t = new Tiger() { age = 100, name = "호치" };
            t.eat();
            t.sleep();
            t.fight();

            ((Cat)t).eat();
            ((Cat)t).fight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = "헤라";
            c.age = 30;
            // ToString :object클래스에 있는 메소드
            // 이 메소드는 오버라이딩이 가능하다.
            MessageBox.Show(c.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tiger t = new Tiger();
            t.name = "호치";
            t.age = 100;
            MessageBox.Show(t.ToString());
        }
    }
}
