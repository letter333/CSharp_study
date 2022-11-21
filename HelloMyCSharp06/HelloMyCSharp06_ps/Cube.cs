using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_ps
{
    public class Cube : Rectangle
    {
        public int h { get; set; }

        public Cube()
        {

        }

        public Cube(int w, int v) : base(w, v)
        {

        }
        public Cube(int h)
        {
            this.h = h;
        }

        public Cube(int w, int v, int h) : base(w, v)
        {
            this.h = h;
        }

        public int getVolume()
        {
            if(this.w == this.v)
            {
                Console.WriteLine("정육면체 넓이");
                return this.getArea() * this.h;
            }
            else
            {
                Console.WriteLine("직육면체 넓이");
                return this.getArea() * this.h;
            }
        }
    }
}
