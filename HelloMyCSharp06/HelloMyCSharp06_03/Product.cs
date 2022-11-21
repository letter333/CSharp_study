using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_03
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product()
        {

        }

        public Product(string Name)
        {
            this.Name = Name;
        }

        public Product(int Price)
        {
            this.Price = Price;
        }

        public Product(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
