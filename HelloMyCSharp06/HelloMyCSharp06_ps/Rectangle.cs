using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_ps
{
    public class Rectangle
    {
        public int w { get; set; }
        public int v { get; set; }
        
        public Rectangle()
        {

        }

        public Rectangle(int w, int v)
        {
            this.w = w;
            this.v = v;
        }

        public int getArea()
        {
            Console.WriteLine("직사각형 넓이");
            return this.w * this.v;
        }
    }
}
