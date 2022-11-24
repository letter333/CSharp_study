using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace HelloMyCSharp09_01
{
    public partial class Form1 : Form, ISubject
    {
        public Form1()
        {
            InitializeComponent();
            Form2 frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm2);
            frm2.Show();

            Form3 frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm3);
            frm3.Show();

            Form4 frm4 = new Form4(this, frm2, frm3);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(frm4);
            frm4.Show();

        }

        List<IObserver> observers = new List<IObserver>();

        public void notify(string msg)
        {
            foreach(IObserver o in observers)
            {
                o.update(msg);
            }
        }

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unregister(IObserver o)
        {
            observers.Remove(o);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notifier n = new Notifier();
            // ISubject s = new Notifier();
            n.register(new Observer1() { name = "스타1" });
            n.register(new Observer2());
            IObserver o1 = new Observer1();
            (o1 as Observer1).name = "허영무의 옵저버";
            n.register(o1);
            n.notify("스타크래프트");
            n.unregister(o1);
            n.notify(", 스2,"); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            notify((sender as TextBox).Text);
        }
    }
}
