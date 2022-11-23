using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp07_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Dog();
            a.Name = "퍼피";
            a.Age = 10;
            a.sleep();
            a.eat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal b = new Cat() { Name = "야옹야옹", Age = 5};
            b.sleep();
            b.eat();
        }

        private void sleep_and_eat(Animal a)
        {
            a.sleep();
            a.eat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sleep_and_eat(new Cat() { Name = "랑이", Age = 7 });
            sleep_and_eat(new Dog() { Name = "행복이", Age = 8 });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat() { Name = "야홍이", Age = 1 });
            animals.Add(new Dog() { Name = "멍뭉이", Age = 10 });
            animals.Add(new Cat() { Name = "캣캣캣", Age = 5 });
            foreach(var item in animals)
            {
                sleep_and_eat(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Animal a = new Rabbit() { Name = "토깽이", Age = 3};
            sleep_and_eat(a);
        }
    }
}
