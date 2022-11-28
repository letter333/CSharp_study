using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString($"yyyy년 MM월 dd일 HH시 MM분 ss초");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteLog("주차");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteLog("출차");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void WriteLog(string contents)
        {
            string log = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] {contents}";
            DataManager.PrintLog(log);
            listBox1.Items.Insert(0, log);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString($"yyyy년 MM월 dd일 HH시 MM분 ss초");
        }
    }
}
