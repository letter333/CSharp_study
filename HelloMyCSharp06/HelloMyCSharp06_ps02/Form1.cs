using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp06_ps02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tryParse 사용시 프로그램 꺼짐 방지
            int num = int.Parse(textBox1.Text);
            label1.Text = new MyMath().Power(num).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            label2.Text = new MyMath().Multi(n1, n2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            label2.Text = new MyMath().Power(n1, n2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int x);
            label2.Text = MyMath3.Power(x).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int x);
            int.TryParse(textBox3.Text, out int y);
            label2.Text = MyMath3.Multi(x, y).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int x);
            int.TryParse(textBox3.Text, out int y);
            label2.Text = MyMath3.Power(x, y).ToString();
        }
    }
}
