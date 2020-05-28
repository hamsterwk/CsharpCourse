using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int leng = 100;
        private Graphics graphics;
        private int depth = 10;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private Pen pen = Pens.Blue;
        Pen getPen()
        {
            if (radioButton1.Checked) return Pens.Blue;
            if (radioButton2.Checked) return Pens.Red;
            if (radioButton3.Checked) return Pens.Green;
            if (radioButton4.Checked) return Pens.Black;
            return Pens.Blue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            else graphics.Clear(Color.White);
            pen = getPen();
            drawCayleyTree(depth, 200, 310, leng, -Math.PI / 2);

        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string newText = this.textBox1.Text;
            try
            {
                depth = int.Parse(newText);
                this.Warning1.Text = newText;
                this.Warning1.Visible = false;
            }
            catch
            {
                this.Warning1.Text = "请输入合法的数字！";
                depth = 10;
                this.Warning1.Visible = true;
            }
            if (depth > 20 || depth <= 0)
            {
                depth = 10;
                this.Warning1.Text = "数字过大或者过小！";
                this.Warning1.Visible = true;
            }
        }

        private void stepText_TextChanged(object sender, EventArgs e)
        {
            string newText = this.stepText.Text;
            try
            {
                leng = int.Parse(newText);
                this.Warning2.Text = newText;
                this.Warning2.Visible = false;
            }
            catch
            {
                this.Warning2.Text = "请输入合法的数字！";
                leng = 100;
                this.Warning2.Visible = true;
            }
            if (leng > 200 || leng <= 0)
            {
                leng = 100;
                this.Warning2.Text = "数字过大或者过小！";
                this.Warning2.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lengLeft_TextChanged(object sender, EventArgs e)
        {
            string newText = this.lengLeft.Text;
            try
            {
                per1 = double.Parse(newText);
                this.Warning3.Text = newText;
                this.Warning3.Visible = false;
            }
            catch
            {
                this.Warning3.Text = "请输入合法的数字！";
                per1 = 0.6;
                this.Warning3.Visible = true;
            }
            if (per1 > 1 || per1 <= 0)
            {
                per1 = 0.6;
                this.Warning3.Text = "数字过大或者过小！";
                this.Warning3.Visible = true;
            }
        }

        private void lengRight_TextChanged(object sender, EventArgs e)
        {
            string newText = this.lengRight.Text;
            try
            {
                per2 = double.Parse(newText);
                this.Warning4.Text = newText;
                this.Warning4.Visible = false;
            }
            catch
            {
                this.Warning4.Text = "请输入合法的数字！";
                per2 = 0.7;
                this.Warning4.Visible = true;
            }
            if (per2 > 1 || per2 <= 0)
            {
                per2 = 0.7;
                this.Warning4.Text = "数字过大或者过小！";
                this.Warning4.Visible = true;
            }
        }

        private void thetaLeft_TextChanged(object sender, EventArgs e)
        {
            string newText = this.thetaLeft.Text;
            try
            {
                th1 = int.Parse(newText)*Math.PI/180;
                this.Warning5.Text = newText;
                this.Warning5.Visible = false;
            }
            catch
            {
                this.Warning5.Text = "请输入合法的数字！";
                th1 = 30 * Math.PI / 180;
                this.Warning5.Visible = true;
            }
            if (th1 > 90 * Math.PI / 180 || th1 <= 0)
            {
                th1 = 30 * Math.PI / 180;
                this.Warning5.Text = "数字过大或者过小！";
                this.Warning5.Visible = true;
            }
        }

        private void thetaRight_TextChanged(object sender, EventArgs e)
        {
            string newText = this.thetaRight.Text;
            try
            {
                th2 = int.Parse(newText) * Math.PI / 180;
                this.Warning6.Text = newText;
                this.Warning6.Visible = false;
            }
            catch
            {
                this.Warning6.Text = "请输入合法的数字！";
                th2 = 20 * Math.PI / 180;
                this.Warning6.Visible = true;
            }
            if (th2 > 90 * Math.PI / 180|| th2 <= 0)
            {
                th2 = 20 * Math.PI / 180;
                this.Warning6.Text = "数字过大或者过小！";
                this.Warning6.Visible = true;
            }
        }
    }
}
