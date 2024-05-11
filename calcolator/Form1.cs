using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolator
{
    public partial class Form1 : Form
    {
        double first, second, result;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "4";
            }
            else
            {
                data.Text = data.Text + "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "6";
            }
            else
            {
                data.Text = data.Text + "6";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(data.Text);
            data.Text = "";
            operation = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.Text==null||data.Text=="0")
            {
                data.Text = "1";
            }
            else
            {
                data.Text = data.Text + "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "2";
            }
            else
            {
                data.Text = data.Text + "2";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "3";
            }
            else
            {
                data.Text = data.Text + "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "5";
            }
            else
            {
                data.Text = data.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "7";
            }
            else
            {
                data.Text = data.Text + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "8";
            }
            else
            {
                data.Text = data.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "9";
            }
            else
            {
                data.Text = data.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = "0";
            }
            else
            {
                data.Text = data.Text + "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(data.Text);
            data.Text = "";
            operation = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(data.Text);
            data.Text = "";
            operation = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(data.Text);
            data.Text = "";
            operation = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
        second =Convert.ToDouble(data.Text);
        if (operation == "+")
        {
            result = first + second;
            data.Text = Convert.ToString(result);
        }
        else if(operation=="-")
        {
            result = first - second;
            data.Text = Convert.ToString(result);
        }
        else if (operation == "*")
        {
            result = first * second;
            data.Text = Convert.ToString(result);
        }
        else if (operation == "/")
        {
            result = first / second;
            data.Text = Convert.ToString(result);
        }
        else
        {
            data.Text = "invalid operation";
        }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            data.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (data.Text == null || data.Text == "0")
            {
                data.Text = ".";
            }
            else
            {
                data.Text = data.Text + ".";
            }
        }
    }
}
