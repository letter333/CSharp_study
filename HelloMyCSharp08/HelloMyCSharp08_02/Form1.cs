using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp08_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Riven riven = new Riven();
            riven.sayHello();
            riven.MoveUp();
            riven.MoveDown();
            riven.MoveLeft();
            riven.MoveRight();
            riven.Attack();
            riven.QKey();
            riven.WKey();
            riven.EKey();
            riven.RKey();

            Timo t = new Timo();
            t.name = "피카츄성우";
            t.level = 50;
            t.sayHello();
            t.Attack();
            t.QKey();
            t.WKey();
            t.EKey();
            t.RKey();
            t.MoveDown();
            t.MoveUp();
            t.MoveLeft();
            t.MoveRight();
        }

    }
}
