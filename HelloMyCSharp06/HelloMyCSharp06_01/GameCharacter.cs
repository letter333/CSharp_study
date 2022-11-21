using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_01
{
    public class GameCharacter
    {
        public static int Count = 0;
        public string id { get; set; }

        public GameCharacter()
        {
            Count++;
        }
    }
}
