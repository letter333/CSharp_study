using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_01
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CompareTo(Product other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
