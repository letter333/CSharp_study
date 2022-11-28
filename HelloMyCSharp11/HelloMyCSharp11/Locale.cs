using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp11
{
    public class Locale
    {
        public string name { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

        public Locale(string name, double lat, double lng)
        {
            this.name = name;
            this.lat = lat;
            this.lng = lng;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
