using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using homework7;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);

        public void QueryOrderById(uint orderId)
        {
            string b = textBox1.Text;
        }
        public void QueryOrdersByGoodsName(string goodsName)
        {
            string b = textBox1.Text;
        }
        public void GetOrdersByCustomerName(string customerName)
        {
            string b = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            uint c = 0;
            string b = textBox1.Text;
            c = uint.Parse(b);
            QueryOrderById(c);
            QueryOrdersByGoodsName(b);
            GetOrdersByCustomerName(b);
            return ;
            textBox3.Text = b ;

        }
        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
            SetParent((int)f2.Handle, (int)this.Handle);
  
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
            SetParent((int)f3.Handle, (int)this.Handle);


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void RemoveOrder(uint orderId)
        {
            string s = textBox2.Text;

        }
        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            "OK",
            "Title",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
            uint a = 0;
            string s = textBox2.Text;
            a = uint.Parse(s);
            RemoveOrder(a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



    }

}
