using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormProgram
{
    public partial class Form1 : Form
    {
        private double number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            number_click("1");
        }

        private void n2_Click(object sender, EventArgs e)
        {
            number_click("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            number_click("3");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            number_click("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            number_click("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            number_click("6");
        }

        private void n7_Click(object sender, EventArgs e)
        {
            number_click("7");
        }
        private void n8_Click(object sender, EventArgs e)
        {
            number_click("8");
        }
        private void n9_Click(object sender, EventArgs e)
        {
            number_click("9");
        }
        private void n0_Click(object sender, EventArgs e)
        {
            number_click("0");
        }

        private void coma_button_Click(object sender, EventArgs e)
        {
            number_click(",");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            math_click("+");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            math_click("-");
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            math_click("*");
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            math_click("/");
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            int textLength = textBox1.Text.Length - 1;

            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text[0..textLength];
            }
        }

        public void number_click(string symbol)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = symbol;
            }
            else
            {
                textBox1.Text = textBox1.Text + symbol;
            }
        }

        private void math_click(string symbol)
        {
            if (number == 0)
            {
                string stringNumber = textBox1.Text;

                number = Convert.ToDouble(stringNumber);

                textBox1.Text = "0";
            }
            else if (number != 0)
            {
                string predRez = $"{Convert.ToString(number).Replace(",",".")}{symbol}{textBox1.Text.Replace(",", ".")}";

                double rez = Convert.ToDouble(new DataTable().Compute(predRez, ""));

                textBox1.Text = Convert.ToString(rez);

                number = 0;
            }
        }
    }
}
