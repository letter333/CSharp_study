using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace useAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=11500611500";
            XElement x = XElement.Load(url);

            var output = from item in x.Descendants("data") select new Weather
            {
                hour = int.Parse(item.Element("hour").Value),
                wf = item.Element("wfKor").Value,
                temp = double.Parse(item.Element("temp").Value)
            };
            List<Weather> w = output.ToList<Weather>();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = w;
        }
    }
}
