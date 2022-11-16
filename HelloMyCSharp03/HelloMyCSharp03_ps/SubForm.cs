using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp03_ps
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        public SubForm(string text)
        {
            InitializeComponent();
            label_output.Text = text;
        }
    }
}
