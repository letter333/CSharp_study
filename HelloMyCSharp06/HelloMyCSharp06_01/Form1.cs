using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp06_01
{
    public partial class Form1 : Form
    {
        public List<GameCharacter> gamers = new List<GameCharacter>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameCharacter g = new GameCharacter();
            g.id = textBox1.Text;
            gamers.Add(g);

            string gamerList = "";
            foreach(var item in gamers)
            {
                gamerList += item.id + Environment.NewLine;
            }
            MessageBox.Show(gamerList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이 게임의 총 유저 수 : " + GameCharacter.Count);
        }
    }
}
