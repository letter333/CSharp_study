using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp06_ps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rectangle r1 = new Rectangle();
            Console.WriteLine("직사각형 가로");
            r1.w = int.Parse(Console.ReadLine());
            Console.WriteLine("직사각형 세로");
            r1.v = int.Parse(Console.ReadLine());
            Console.WriteLine(r1.getArea()); 

            Circle c1 = new Circle();
            Console.WriteLine("원 반지름");
            c1.r = int.Parse(Console.ReadLine());
            Console.WriteLine(c1.getArea());
            Console.WriteLine(c1.getRound());
            
            Cube cube = new Cube();
            Console.WriteLine("직육면체 가로");
            cube.w = int.Parse(Console.ReadLine());
            Console.WriteLine("직육면체 세로");
            cube.v = int.Parse(Console.ReadLine());
            Console.WriteLine("직육면체 높이");
            cube.h = int.Parse(Console.ReadLine());
            Console.WriteLine(cube.getVolume());
            
            Sphere sphere = new Sphere();
            Console.WriteLine("구 반지름");
            sphere.r = int.Parse(Console.ReadLine());
            Console.WriteLine(sphere.getVolume());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 직사각형 넓이
            int w = int.Parse(textBox1.Text);
            int v = int.Parse(textBox2.Text);
            Rectangle rectangle = new Rectangle(w, v);
            label5.Text = button1.Text + " " + rectangle.getArea().ToString();
            MessageBox.Show(rectangle.getArea().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 원 둘레
            int r = int.Parse(textBox4.Text);
            Circle circle = new Circle(r);
            label5.Text = button2.Text + " " + circle.getRound().ToString();
            MessageBox.Show(circle.getRound().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 원 넓이
            int r = int.Parse(textBox4.Text);
            Circle circle = new Circle(r);
            label5.Text = button3.Text + " " + circle.getArea().ToString();
            MessageBox.Show(circle.getArea().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 직육면체 부피
            int w = int.Parse(textBox1.Text);
            int v = int.Parse(textBox2.Text);
            int h = int.Parse(textBox3.Text);
            Cube cube = new Cube(w, v, h);
            label5.Text = button4.Text + " " + cube.getVolume().ToString();
            MessageBox.Show(cube.getVolume().ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 구 부피
            int r = int.Parse(textBox4.Text);
            Sphere sphere = new Sphere(r);
            label5.Text = button5.Text + " " + sphere.getVolume().ToString();
            MessageBox.Show(sphere.getVolume().ToString());
        }
    }
}
