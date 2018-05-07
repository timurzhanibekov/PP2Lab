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
        double firstnumber = 0 ;
        double secondnumber = 0;
        double result = 0;
        double result2 = 0;
        double result3 = 0;
        double memory = 0;
        int index = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void numbers(object sender, EventArgs e)
        {   if (index==0)
            {
                display.Text = "";
                index = 1; 
            }     
            Button btn = sender as Button;
            display.Text += btn.Text;

        }
        
        private void operations(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstnumber = double.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";
        }

        private void result_Click(object sender, EventArgs e)
        {
            secondnumber = double.Parse(display.Text);
            if (operation == "+")
                result = firstnumber + secondnumber;
            if (operation == "-")
                result = firstnumber - secondnumber;
            if (operation == "x")
                result = firstnumber * secondnumber;
            if (operation == "/")
                result = firstnumber / secondnumber;
            if (operation == "%")
                result = firstnumber * secondnumber / 100;
            if (operation == "X^Y")
                result = Math.Pow(firstnumber, secondnumber);
            display.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            result = 0;
            firstnumber = 0;
            secondnumber = 0;
            operation = "";
            index = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "<")
            {               
                string s = "";
                for (int i = 0; i < display.Text.Length - 1; i++)
                {
                    s += display.Text[i];
                }
                string k = "";
                for (int i = 0; i < s.Length; i++)
                {
                    k += s[i];
                }
                display.Text = k;
                if (k.Length == 0 || k[k.Length - 1] == '-')
                    display.Text = "0";
                index = 0;
                string z = "";
                int n;
                for (int i = 0; i < k.Length; i++)
                {
                    if (k[i] == ',')
                    {
                        n = i;
                        for (int j = 0; j < n; j++)
                        {
                            z += k[j];
                        }
                        display.Text = z;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display.Text = 0 + "";
        }

        private void oneclick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstnumber = double.Parse(display.Text);
            if (btn.Text == "√")
                result2 = Math.Sqrt(firstnumber);
            if (btn.Text == "sin")
                result2 = Math.Sin(firstnumber * Math.PI/180);
            if (btn.Text == "cos")
                result2 = Math.Cos(firstnumber * Math.PI / 180);
            if (btn.Text == "tan")
                result2 = Math.Sin(firstnumber * Math.PI / 180) / Math.Cos(firstnumber * Math.PI / 180);
            if (btn.Text == "ctg")
                result2 = Math.Cos(firstnumber * Math.PI / 180) / Math.Sin(firstnumber * Math.PI / 180);
            if (btn.Text == "ln")
                result2 = Math.Log(firstnumber);
            if (btn.Text == "log")
                result2 = Math.Log10(firstnumber);
            if (btn.Text == "1/X")
                result2 = 1 / firstnumber;
            if (btn.Text == "+/-")
                result2 = -firstnumber; 
            if (btn.Text == "X^2")
                result2 = Math.Pow(firstnumber, 2);
            if (btn.Text == "n!")
            {
                result2 = 1;
                for (int i = 1; i <= firstnumber; i++)
                {
                    result2 *= i;
                }
            }
            display.Text = result2.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "п")
                result3 = Math.PI;
            display.Text = result3.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            memory = double.Parse(display.Text);
            display.Text = "0";
            index = 0;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            display.Text = memory.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            memory = memory + double.Parse(display.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            memory = memory - double.Parse(display.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            secondnumber = 0;
            index = 0;
        }

        private void point(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text += ",";

            if (display.Text.Contains(","))
            {
                
            }
            else
            {
                display.Text += ",";
            }


        }

        private void xcub_Click(object sender, EventArgs e)
        {
            int x = 0;
            int res;
            x = int.Parse(display.Text);
            res = x;
            for (int i = 0; i < 2; i++)
            {
                res *= x;
            }
            display.Text = res.ToString();
        }
    }
}
