using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calci
{
    public partial class Form1 : Form
    {
        string Operation;
        Double FirstNumber;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "1";
            }
            else
            {
                Display.Text = Display.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "2";
            }
            else
            {
                Display.Text = Display.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "3";
            }
            else
            {
                Display.Text = Display.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "4";
            }
            else
            {
                Display.Text = Display.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "5";
            }
            else
            {
                Display.Text = Display.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "6";
            }
            else
            {
                Display.Text = Display.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "7";
            }
            else
            {
                Display.Text = Display.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "8";
            }
            else
            {
                Display.Text = Display.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "9";
            }
            else
            {
                Display.Text = Display.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text = Display.Text + "0";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "+";
            
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "-";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "/";
        }

        private void nd_Click(object sender, EventArgs e)
        {
            if (FirstNumber >= 0)
            {
                FirstNumber= Convert.ToDouble(Display.Text);
                Display.Text= FirstNumber+".";  
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void ne_Click(object sender, EventArgs e)
        {
            double SecondNumber= Convert.ToDouble(Display.Text);
            double Result;

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Display.Text = "Cannot divide by zero";

                }
                else
                {

                    Result = (FirstNumber / SecondNumber);
                    Display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }


        }
    }
}
