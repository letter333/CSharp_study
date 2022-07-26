﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp10_01
{
    public delegate void VoidFunc();
    public delegate int IntegerFunc();
    public delegate void ParameterFunc(int i);
    public delegate int IntegerParamFunc(int i);
    public partial class Form1 : Form
    {
        public int power(int num)
        {
            return num * num;
        }

        public void executeFunc(IntegerParamFunc i, int num)
        {
            MessageBox.Show("num의 제곱 : " + i(num));
        }

        public void myTest()
        {
            MessageBox.Show("Test");
        }

        public void yourTest()
        {
            MessageBox.Show("Your Test");
        }
        public void executeFunc(VoidFunc v, int c)
        {
            for(int i = 0; i < c; i++)
            {
                v();
            }
        }

        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            products.Add(new Product() { id = 5, name = "감자", price = 100 });
            products.Add(new Product() { id = 1, name = "돌", price = 50 });
            products.Add(new Product() { id = 3, name = "칫솔살균기", price = 0 });

            button4.Click += (s, e) =>
            {
                MessageBox.Show((s as Button).Text + "버튼4 클릭");
            };

            button4.Click += delegate (object s, EventArgs e)
            {
                MessageBox.Show((s as Button).Text);
            };

            button4.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            executeFunc(myTest, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            executeFunc(delegate ()
            {
                MessageBox.Show("안녕하세요");
            }, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            executeFunc( () => {
                MessageBox.Show("aaa");
            }, 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            executeFunc(power, 10);

            VoidFunc myVoid = yourTest;
            myVoid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            executeFunc(delegate (int n) { return n * n * n; }, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            executeFunc((n) => n * n * n * n, 10);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            products.Sort(delegate (Product a, Product b)
            {
                return a.id.CompareTo(b.id);
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            products.Sort((a, b) => a.price.CompareTo(b.price));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach(Product p in products)
            {
                MessageBox.Show($"{p.name}, {p.price}, {p.id}");
            }
        }
    }
}
