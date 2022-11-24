using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp09_ps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            studentBindingSource.Add(new Student() { name = textBox1.Text, hakbeon = textBox2.Text, gender = textBox3.Text });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 이름으로 찾아서 나머지 값 수정
            string name = textBox1.Text;
            for(int i = 0; i < studentBindingSource.Count; i++)
            {
                Student s = studentBindingSource[i] as Student;
                if(s.name == name)
                {
                    s.hakbeon = textBox2.Text;
                    s.gender = textBox3.Text;
                    studentBindingSource[i] = s;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 이름으로 삭제
            string name = textBox1.Text;
            for (int i = studentBindingSource.Count - 1; i >= 0; i--)
            {
                Student s = studentBindingSource[i] as Student;
                if (s.name == name)
                {
                    studentBindingSource.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 이름으로 찾아서 나머지 값 수정
            string name = textBox1.Text;
            List<Student> ss = new List<Student>();
            for (int i = 0; i < studentBindingSource.Count; i++)
            {
                Student s = studentBindingSource[i] as Student;
                if (s.name == name)
                {
                    ss.Add(s);
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ss;
        }
    }
}
