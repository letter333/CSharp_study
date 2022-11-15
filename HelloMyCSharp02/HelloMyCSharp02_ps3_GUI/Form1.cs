using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp02_ps3_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show(sum.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sub = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
            MessageBox.Show(sub.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mul = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            MessageBox.Show(mul.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sub = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            MessageBox.Show(sub.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int remain = int.Parse(textBox1.Text) % int.Parse(textBox2.Text);
            MessageBox.Show(remain.ToString());
        }
    }
}
