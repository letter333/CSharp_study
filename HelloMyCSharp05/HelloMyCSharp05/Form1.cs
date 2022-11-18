using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(char c = '가'; c <= '힣'; c++)
            {
                Console.Write(c);
            }
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(0, 100);
            for (char c = '가'; c <= '힣'; c++)
            {
                label.Text += c;
                if(c % 100 == 0)
                {
                    label.Text += Environment.NewLine; // 환겨에 맞게 한 줄 띄는 것
                }
                label.Name = "mylabel";
                Controls.Add(label);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var item in Controls)
            {
                if(item is Label)
                {
                    Label temp = item as Label;
                    if(temp.Name == "mylabel")
                    {
                        Controls.Remove(temp);
                        break;
                    }
                }
            }
        }
    }
}
