using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_ps
{
    internal class Sphere : Circle
    {
        public Sphere()
        {

        }

        public Sphere(int r) : base(r)
        {

        }

        public double getVolume()
        {
            Console.WriteLine("구 부피");
            return (4.0 / 3.0) * PI * r * r * r;
        }
    }
}
