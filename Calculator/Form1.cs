using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string firstNum = "0", secondNum = "0", operation = "", userDisplay = "0";
        double results = 0.0;
        bool haveDecimal = false;

        void datainput(string inputNum)
        {
            string substr = userDisplay.Substring(userDisplay.Length - 1);

            if (substr == "0" && inputNum != ".")
            {
                displayText.Text = "";
                userDisplay = inputNum;
                displayText.Text += userDisplay;
            }
            else
            {
                if (substr == "." && inputNum == ".")
                {
                    userDisplay = "Invalid Input";
                } else if (substr != "." && haveDecimal == true && inputNum == ".")
                {
                    userDisplay = "Invalid Input";
                } else if (substr == ".")
                {
                    haveDecimal = true;
                    userDisplay += inputNum;
                }
                else
                {
                    userDisplay += inputNum;
                }

                displayText.Text = userDisplay;
            }
        }

        void operationHandler  (string operation)
        {
            this.operation = operation;
            haveDecimal = false;
            firstNum = userDisplay;
            userDisplay = "0";
            prevText.Text = firstNum + " " + operation;
            displayText.Text = userDisplay;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            datainput("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            datainput("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            datainput("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            datainput("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            datainput("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            datainput("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            datainput("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            datainput("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            datainput("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            datainput("0");
        }

        private void sum_Click(object sender, EventArgs e)
        {
            operationHandler("+");
        }

        private void sub_Click(object sender, EventArgs e)
        {
            operationHandler("-");
        }

        private void mul_Click(object sender, EventArgs e)
        {
            operationHandler("*");
        }

        private void decimalbtn_Click(object sender, EventArgs e)
        {
            datainput(".");
        }

        private void div_Click(object sender, EventArgs e)
        {
            operationHandler("/");
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(firstNum == "0")
            {
                displayText.Text = "Za mara";
            } else
            {
                secondNum = userDisplay;

                double first, second;

                first = Convert.ToDouble(firstNum);
                second = Convert.ToDouble(secondNum);



                switch (operation)
                {
                    case "+":
                        results = first + second;
                        break;
                    case "-":
                        results = first - second;
                        break;
                    case "*":
                        results = first * second;
                        break;
                    case "/":
                        results = first / second;
                        break;
                    default:
                        displayText.Text = "Get Outa here main";
                        break;
                }

                displayText.Text = Convert.ToString(results);
                prevText.Text += " " + secondNum; 
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            userDisplay = "0";
            displayText.Text = userDisplay;
            firstNum = secondNum = "0";
            operation = "";
            haveDecimal = false;
            prevText.Text = "0";
        }
    }
}
