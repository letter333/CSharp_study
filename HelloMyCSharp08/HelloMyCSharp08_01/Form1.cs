using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Price = 1000, Name = "감자"});
            products.Add(new Product() { Id = 3, Price = 500, Name = "파"});
            products.Add(new Product() { Id = 2, Price = 100, Name = "젤리"});

            foreach(Product p in products)
            {
                MessageBox.Show($"{p.Name}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Price = 1000, Name = "감자" });
            products.Add(new Product() { Id = 3, Price = 500, Name = "파" });
            products.Add(new Product() { Id = 2, Price = 100, Name = "젤리" });

            products.Sort();

            foreach (Product p in products)
            {
                MessageBox.Show($"{p.Name}");
            }
        }
    }
}
