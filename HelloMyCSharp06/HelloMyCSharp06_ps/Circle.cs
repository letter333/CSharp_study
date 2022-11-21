using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_ps
{
    public class Circle
    {
        public int r { get; set; }
        public const double PI = 3.14;

        public Circle()
        {

        }

        public Circle(int r)
        {
            this.r = r;
        }

        public double getRound()
        {
            Console.WriteLine("원 둘레");
            return 2 * PI * r;
        }

        public double getArea()
        {
            Console.WriteLine("원 넓이");
            return PI * r * r;
        }
    }
}
