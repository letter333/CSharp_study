using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp09_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView3.Columns.Add("name", "이름");
            dataGridView3.Columns.Add("gender", "성별");
            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
            productBindingSource.Add(new Product() { Name = "토마토", Price = 700 });
            productBindingSource.Add(new Product() { Name = "젤리", Price = 100 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "김치", Price = 5000 });
            products.Add(new Product() { Name = "시금치", Price = 990 });
            products.Add(new Product() { Name = "감귤", Price = 4990 });

            // 반드시  null 로 초기화해주고 나서 datasource를 넣는다.
            // 만약 products가 추가 삭제 돼도, 마찬가지로 datasource를 null로 해주고
            // datasource 다시 products로 바꿔야 됨
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = products;
        }
    }
}
