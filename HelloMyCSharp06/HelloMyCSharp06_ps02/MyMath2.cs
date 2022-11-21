using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_ps02
{
    public class MyMath2
    {
        public static int Power(int x)
        {
            return x * x;
        }

        public static int Power(int x, int c)
        {
            int res = 1;
            for(int i = 0; i < c; i++)
            {
                res *= x;
            }

            return res;
        }

        public static int Multi(int x, int y)
        {
            return x * y;
        }
    }
}
