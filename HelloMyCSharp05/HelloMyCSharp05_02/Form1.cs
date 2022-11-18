using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp05_02
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
            Random random = new Random();
            int[] arr = new int[4];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                for(int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            button1.Text = arr[0].ToString();
            button5.Text = button1.Text;
            button2.Text = arr[1].ToString();
            button6.Text = button2.Text;
            button3.Text = arr[2].ToString();
            button7.Text = button3.Text;
            button4.Text = arr[3].ToString();
            button8.Text = button4.Text;
        }

        public void addText(object sender, EventArgs e)
        {
            Button button = sender as Button;
            list.Add(button.Text);
            label4.Text = "";
            foreach(var item in list)
            {
                label4.Text += item + " ";
            }
        }

        public void removeText(object sender, EventArgs e)
        {
            Button button = sender as Button;
            list.Remove(button.Text);
            label4.Text = "";
            foreach (var item in list)
            {
                label4.Text += item + " ";
            }
        }
    }
}
