using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public static decimal sum = 0;
        public static List<Decimal> operatorList = new List<Decimal>();
        string user = string.Empty;
        string firstOperand = string.Empty;
        string secondOperand = string.Empty;
        char operation;
        double dbresult = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "1";
            this.result_tb.Text += user;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "2";
            this.result_tb.Text += user;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "3";
            this.result_tb.Text += user;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "4";
            this.result_tb.Text += user;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "5";
            this.result_tb.Text += user;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "6";
            this.result_tb.Text += user;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "7";
            this.result_tb.Text += user;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "8";
            this.result_tb.Text += user;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "9";
            this.result_tb.Text += user;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += "0";
            this.result_tb.Text += user;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            user += ".";
            this.result_tb.Text += user;
        }

        private void slash_Click(object sender, EventArgs e)
        {
            firstOperand = user;
            operation = '/';
            user = string.Empty;
            operatorList.Add(Convert.ToDecimal(result_tb.Text));
        }

        private void asterisk_Click(object sender, EventArgs e)
        {
            firstOperand = user;
            operation = '*';
            user = string.Empty;
            operatorList.Add(Convert.ToDecimal(result_tb.Text));
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstOperand = user;
            operation = '-';
            user = string.Empty;
            operatorList.Add(Convert.ToDecimal(result_tb.Text));
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstOperand = user;
            operation = '+';
            user = string.Empty;
            operatorList.Add(Convert.ToDecimal(result_tb.Text));
        }

        private void ce_Click(object sender, EventArgs e)
        {
            this.result_tb.Text = "";
            this.user = string.Empty;
            this.firstOperand = string.Empty;
            this.secondOperand = string.Empty;
            sum = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            secondOperand = user;
            double num1, num2;
            firstOperand = firstOperand.Replace(".", ",");
            num1 = Convert.ToDouble(firstOperand);
            secondOperand = secondOperand.Replace(".", ",");
            num2 = Convert.ToDouble(secondOperand);
            if (operation == '+')
            {
                operatorList.Add(Convert.ToDecimal(result_tb.Text));
                for (int i = 0; i < operatorList.Count; i++)
                {
                    sum += operatorList[i];
                }
                operatorList.Clear();
                var result = sum;
                sum = 0;
                result_tb.Text = result.ToString();
            }
            else if (operation == '-')
            {
                dbresult = num1 - num2;
                result_tb.Text = dbresult.ToString();
            }
            else if (operation == '*')
            {
                sum = 1;
                operatorList.Add(Convert.ToDecimal(result_tb.Text));
                for (int i = 0; i < operatorList.Count; i++)
                {
                    sum *= operatorList[i];
                }
                operatorList.Clear();
                var result = sum;
                sum = 1;
                result_tb.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    dbresult = num1 / num2;
                    result_tb.Text = dbresult.ToString();
                }
                else
                {
                    result_tb.Text = "Didn't entered operation ! Please enter correct operation";
                }

            }
            
        }

        private void c_Click(object sender, EventArgs e)
        {

        }
    }
    }

