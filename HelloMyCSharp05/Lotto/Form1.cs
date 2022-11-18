using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        public List<int[]> getLotto()
        {
            Random random = new Random();
            int num = int.Parse(textBox1.Text);
            List<int[]> list = new List<int[]>();

            for (int i = 0; i < num; i++)
            {
                int[] arr = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    int randomN = random.Next(45) + 1;
                    arr[j] = randomN;
                    for (int k = 0; k < j; k++)
                    {
                        if (arr[j] == arr[k])
                        {
                            j--;
                            break;
                        }
                    }
                }
                Array.Sort(arr);
                list.Add(arr);
            }

            return list;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            List<int[]> list = getLotto();
            int num = int.Parse(textBox1.Text);
            Random random = new Random();
            
            if (num > 5)
            {
                label2.Text = "숫자를 다시 입력해주세요.";
                return;
            }
            for (int i = 0; i < num; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (list[i][j] < 10)
                    {
                        label2.Text += "0";
                    }
                    label2.Text += list[i][j] + "  ";
                }

                int bonus = random.Next(45) + 1;
                for(int j = 0; j < 6; j++)
                {
                    if (list[i][j] == bonus)
                    {
                        bonus = random.Next(45) + 1;
                        j = -1;
                    }
                }
                if(bonus < 10)
                {
                    label2.Text += $"보너스 번호 : 0{bonus}\n";
                } else
                {
                   label2.Text += $"보너스 번호 : {bonus}\n";
                }
            }
        }
    }
}
