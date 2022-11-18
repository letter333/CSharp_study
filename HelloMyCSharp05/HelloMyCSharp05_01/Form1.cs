using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = i;
            }
            foreach(var item in numbers1)
            {
                Console.WriteLine(item);
            }
            List<int> numbers2 = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                numbers2.Add(i * i);
            }
            foreach(var item in numbers2)
            {
                Console.WriteLine(item);
            }
            for(int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
            for(int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }

            ArrayList test = new ArrayList();
            test.Add("안녕");
            test.Add(123);
            test.Add('a');
            test.Add(new Random());
        }
    }
}
