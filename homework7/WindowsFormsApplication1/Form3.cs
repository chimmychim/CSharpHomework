using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework7;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //public void UpdateOrderCustomer(uint orderId, Customer newCustomer)
        //{
        //    uint d = 0;
        //    string e = textBox4.Text;
        //    d = uint.Parse(e);
        //    string f = textBox1.Text;
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "OK",
    "Title",
    MessageBoxButtons.OK,
    MessageBoxIcon.Asterisk);
        }

        public void QueryOrderById(uint orderId)
        {
            string b = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint c = 0;
            string b = textBox1.Text;
            c = uint.Parse(b);
            QueryOrderById(c);
            return;
            textBox2.Text = b;
            textBox3.Text = b;
                textBox4.Text = b;
                    textBox5.Text = b;
                    textBox6.Text = b;

        }
    }
}
