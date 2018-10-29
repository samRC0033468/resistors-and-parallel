using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resistors_and_parrllel
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

        private void button2_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5;

            try
            {
                r1 = double.Parse(textBox4.Text);
            }
            catch
            {
                r1 = 0;
            }
            try
            {
                r2 = double.Parse(textBox3.Text);
            }
            catch
            {
                r2 = 0;
            }
            try
            {
                r3 = double.Parse(textBox5.Text);
            }
            catch
            {
                r3 = 0;
            }
            try
            {
                r4 = double.Parse(textBox6.Text);
            }
            catch
            {
                r4 = 0;
            }
            try
            {
                r5 = double.Parse(textBox7.Text);
            }
            catch
            {
                r5 = 0;
            }

            double rt = r1 + r2 + r3 + r4 + r5;
            label1.Text = "total resistance =" + rt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5;

            double rrt = 0;

            try
            {
                r1 = double.Parse(textBox1.Text);
                rrt = rrt + 1 / r1;
            }
            catch
            {
                
            }
            try
            {
                r2 = double.Parse(textBox2.Text);
                rrt = rrt + 1 / r2;
            }
            catch
            {
                
            }
            try
            {
                r3 = double.Parse(textBox8.Text);
                rrt = rrt + 1 / r3;
            }
            catch
            {
                
            }
            try
            {
                r4 = double.Parse(textBox9.Text);
                rrt = rrt + 1 / r4;
            }
            catch
            {
                
            }
            try
            {
                r5 = double.Parse(textBox10.Text);
                rrt = rrt + 1 / r5;
            }
            catch
            {
                
            }

            double rt = 1/rrt;
            label2.Text = "total resistance =" + rt;
        }


    }
}
