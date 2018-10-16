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
            this.AutoScaleBaseSize = new Size(6, 14);
            this.ClientSize = new Size(600, 400);
            this.Paint += new PaintEventHandler(this.Form1_Paint);
            this.Click += new EventHandler(this.Redraw);
            //string a = textBox1.Text;
            //string b = textBox2.Text;
            //double per1 = Double.Parse(a);
            //double per2 = Double.Parse(b);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawTree(10, 200, 380, 100, -PI / 2);
        }
        private void Redraw(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private Graphics graphics;

        const double PI = Math.PI;
        double th1 = 35 * Math.PI / 180;
        double th2 = 25 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        Random rnd = new Random();
        double rand()
        {
            return rnd.NextDouble();
        }

        void drawTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double k = 1.6;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng *k* Math.Cos(th);
            double y2 = y0 + leng *k* Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            //drawLine2(x0, y0, x2, y2);

            drawTree(n - 1, x1, y1, per1 * leng * (0.5 + rand()), th + th1 * (0.5 + rand()));
            drawTree(n - 1, x2, y2, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));
            if (rand() > 0.6)
                drawTree(n - 1, x1, y1, per2 * leng * (0.5 + rand()), th - th2 * (0.5 + rand()));
            //drawTree(n - 1, x2, y2, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
        //void drawLine2(double x0, double y0, double x2, double y2)
        //{
        //    graphics.DrawLine(
        //        Pens.Red,
        //        (int)x0, (int)y0, (int)x2, (int)y2);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawTree(10, 200, 310, 100, -Math.PI / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}