using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text.Equals("admin") && textBox_pw.Text.Equals("1234")) {
                MessageBox.Show("관리자님 환영합니다.");
            } else
            {
                MessageBox.Show("너 누구?");
            }
        }
    }
}
