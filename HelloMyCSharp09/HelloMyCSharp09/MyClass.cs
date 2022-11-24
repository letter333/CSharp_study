using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp09
{
    public class MyClass : MyBase
    {
        public int num { get; set; }
        public void printMsg(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg + "_Test_" + num);
        }
        
        public override void print(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }

        private static MyClass _instance = null;

        private MyClass()
        {

        }

        // C# Style
        public static MyClass getInstance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new MyClass();
                }
                return _instance;
            }
        }

        // Java Style
        public static MyClass _getInstance()
        {
            if(_instance == null)
            {
                _instance = new MyClass();
            }
            return _instance;
        }
    }
}
