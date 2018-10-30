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
        //this part of the code is making the text boxs equal r1 through r5 so that they can be added together


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
            //the next 2 lines of code adds all the values of the text boxs together and also because each box equals 0 if you dont input a value it will class it as 0


            double rt = r1 + r2 + r3 + r4 + r5;
            label1.Text = "total resistance =" + rt;

        }

        private void button1_Click(object sender, EventArgs e)
            //this is making the text boxs equal 1 through 5 resistors so that the calculations can be performed when you input the numbers into the text boxs

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
            //this is saying to get the total resistance like series calculation except you divide 1 by the total.

            double rt = 1/rrt;
            //this is the code to display the answer on the label.
            label2.Text = "total resistance =" + rt;
        }


    }
}
