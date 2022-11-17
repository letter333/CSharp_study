using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp03_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_side.Height = button3.Height;
            panel_side.Top = button3.Top;
            firstControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_side.Height = button3.Height;
            panel_side.Top = button3.Top;
            firstControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_side.Height = button4.Height;
            panel_side.Top = button4.Top;
            mySecondControl1.BringToFront();
        }

        private void myClickEvent(object sender, EventArgs e)
        {
            // object : 모든 객체의 조상
            // 이 sender가 이벤트를 발생시킨 주체
            // EventArgs : 이벤트에 연관된 내용이 저장된 객체

            // object 타입의 sender를 Button으로 형변환
            Button btn = (sender as Button);
            panel_side.Height = btn.Height;
            panel_side.Top = btn.Top;
        }
    }
}
