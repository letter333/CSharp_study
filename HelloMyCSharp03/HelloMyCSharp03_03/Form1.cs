﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pw = textBox2.Text;
            if(id == "admin" && pw =="1234")
            {
                MessageBox.Show("관리자");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2(textBox1.Text, textBox2.Text).ShowDialog();
            Show();
        }
    }
}
