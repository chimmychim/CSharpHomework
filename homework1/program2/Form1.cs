using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text; 
            string b = textBox2.Text;
            double c = Double.Parse(a);
            double d = Double.Parse(b);
            double sq = c * d;
            textBox3.Text = a + "和" + b + "的乘积是：" + sq;
        }
    }
}
