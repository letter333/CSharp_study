using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString($"yyyy년 MM월 dd일 HH시 MM분 ss초");

            try
            {
                textBox1.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox2.Text = DataManager.Cars[0].carNumber;
                textBox3.Text = DataManager.Cars[0].driverName;
                textBox4.Text = DataManager.Cars[0].phoneNumber;
                textBox5.Text = textBox1.Text;
            }
            catch (Exception)
            {
            }
            if(DataManager.Cars.Count > 0)
            {
                dataGridView1.DataSource = DataManager.Cars;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WriteLog("주차");
            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호 입력하세요");
            }
            else if(textBox2.Text.Trim() == "")
            {
                MessageBox.Show("차량 번호 입력해주세요");
            }
            else
            {
                try
                {
                    // Single = List에서 원하는 거 하나만 가져오는 것
                    // 값을 갖고 오는게 아니라 참조값을 가져옴
                    // 값을 찾지 못하면 catch로 빠짐.
                    ParkingCar car = DataManager.Cars.Single(x => x.ParkingSpot.ToString() == textBox1.Text);
                    if(car.carNumber.Trim() != "")
                    {
                        MessageBox.Show("해당 공간에 이미 차가 있습니다.");
                    }
                    else
                    {
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;

                        DataManager.Save(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        string contents = $"주차 공간 {textBox1.Text}에 {textBox2.Text}차를 주차했습니다.";
                        WriteLog(contents);
                        MessageBox.Show(contents);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"주차공간 {textBox1.Text}은/는 없습니다.");
                    WriteLog($"주차공간 {textBox1.Text}은/는 없습니다.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("출차 공간 번호 입력하세요");
            }
            else
            {
                try
                {
                    // Single = List에서 원하는 거 하나만 가져오는 것
                    // 값을 갖고 오는게 아니라 참조값을 가져옴
                    // 값을 찾지 못하면 catch로 빠짐.
                    ParkingCar car = DataManager.Cars.Single(x => x.ParkingSpot.ToString() == textBox1.Text);
                    // DataManager.Cars.Single(delegate(ParkingCar x) { return x.ParkingSpot.ToString == textBox1.Text; }
                    if (car.carNumber.Trim() == "")
                    {
                        MessageBox.Show("아직 차가 없습니다.");
                    }
                    else
                    {
                        string oldCar = car.carNumber;
                        car.carNumber = "";
                        car.driverName = "";
                        car.phoneNumber = "";
                        car.parkingTime = new DateTime();

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;

                        DataManager.Save(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, true);
                        string contents = $"주차 공간 {textBox1.Text}에 {oldCar}차를 출차했습니다.";
                        WriteLog(contents);
                        MessageBox.Show(contents);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"주차공간 {textBox1.Text}은/는 없습니다.");
                    WriteLog($"주차공간 {textBox1.Text}은/는 없습니다.");
                }
            }
        }

        private string lookUpParkingSpot(int parkingSpot)
        {
            string parkedCarNum = "";
            foreach (var item in DataManager.Cars)
            {
                if(item.ParkingSpot == parkingSpot)
                {
                    parkedCarNum = item.carNumber;
                    break;
                }
            }

            return parkedCarNum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int parkingSport = int.Parse(textBox1.Text);
                string parkingCar = lookUpParkingSpot(parkingSport);
                string contents = "";
                if(parkingCar.Trim() != "")
                {
                    contents = $"주차공간 {parkingSport}에 주차된 차는 {parkingCar}입니다.";
                }
                else
                {
                    contents = $"주차공간 {parkingSport}에 차가 없습니다.";
                }

                WriteLog(contents);
                MessageBox.Show(contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                WriteLog(ex.Message + ex.StackTrace + "조회");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spot_add_delete(textBox5.Text, "insert");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spot_add_delete(textBox5.Text, "delete");
        }

        private void spot_add_delete(string text, string v)
        {
            text = text.Trim();
            int.TryParse(text, out int pSpot);
            if(pSpot <= 0)
            {
                WriteLog("주차 공간 번호는 0이상의 숫자여야 함.");
                MessageBox.Show("주차 공간 번호는 0 이상의 숫자여야 함");
                return;
            }
            string contents = "";
            bool check = DataManager.Save(v, text, out contents);
            if(check)
            {
                button6.PerformClick();
            }
            MessageBox.Show(contents);
            WriteLog(contents);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView1.DataSource = null;
            if(DataManager.Cars.Count > 0)
            {
                dataGridView1.DataSource = DataManager.Cars;
            }
        }

        private void WriteLog(string contents)
        {
            string log = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] {contents}";
            DataManager.PrintLog(log);
            listBox1.Items.Insert(0, log);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString($"yyyy년 MM월 dd일 HH시 MM분 ss초");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParkingCar car = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
            textBox1.Text = car.ParkingSpot.ToString();
            textBox2.Text = car.carNumber;
            textBox3.Text = car.driverName;
            textBox4.Text = car.phoneNumber;
            textBox5.Text = textBox1.Text;
        }
    }
}
