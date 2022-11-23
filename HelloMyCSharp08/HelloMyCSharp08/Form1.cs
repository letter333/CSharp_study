using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student<int> s = new Student<int>();
            s.age = 10;
            s.name = "이동준";
            s.hakbeon = 09;

            MessageBox.Show($"이름 : {s.name}, 나이 : {s.age}, 학번 : {s.hakbeon}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student<string> s = new Student<string>("조영탁", "09", 20);
            MessageBox.Show($"이름 : {s.name}, 나이 : {s.age}, 학번 : {s.hakbeon}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyHakbeon h = new MyHakbeon("경북산업직업전문학교", 1);
            Student<MyHakbeon> s = new Student<MyHakbeon>(h, "이유나", 24);
            Student<MyHakbeon> s2 = new Student<MyHakbeon>(new MyHakbeon("영진직업전문학교", 2), "이동준", 34);
            Student<MyHakbeon> s3 = new Student<MyHakbeon>();
            s3.name = "김홍근";
            s3.age = 40;
            s3.hakbeon = h;
            s3.hakbeon = new MyHakbeon("코리아IT", 3);
            MessageBox.Show($"이름 : {s.name}, 나이 : {s.age}, 학번 : {s.hakbeon.name}, {s.hakbeon.number}");
        }
    }
}
