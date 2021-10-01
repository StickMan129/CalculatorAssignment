using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcLibrary;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        CalculatorFunctions calc = new CalculatorFunctions();
        static object num1;
        static object num2;


        private void allButtons_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt16(((Button)sender).Text);
            txtInput.Text += n.ToString();
        }
        private void allEquations_Click(object sender, EventArgs e)
        {
            string m;
            m = ((Button)sender).Text;
            txtInput.Text += " "+ m + " ";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            List<string> list = new List<string>();

            list = input.Split(" ").ToList();

            try { num1 = double.Parse(list[0]); } catch { }
            try { num2 = double.Parse(list[2]); } catch { }

            try { num1 = int.Parse(list[0]); } catch { }
            try { num2 = int.Parse(list[2]); } catch { }

            if (list[1].Contains("+"))
            {
                if (num1 is double && num2 is double)
                    txtInput.Text = (calc.add((double)num1, (double)num2)).ToString();
                else if (num1 is double && num2 is int)
                    txtInput.Text = (calc.add((double)num1, (int)num2)).ToString();
                else if (num1 is int && num2 is double)
                   txtInput.Text = (calc.add((int)num1, (double)num2)).ToString();
                else if (num1 is int && num2 is int)
                    txtInput.Text = (calc.add((int)num1, (int)num2)).ToString();
                
            }
                
            else if (input.Contains("-"))
            {
                if (num1 is double && num2 is double)
                    txtInput.Text = (calc.sub((double)num1, (double)num2)).ToString();
                else if (num1 is double && num2 is int)
                    txtInput.Text = (calc.sub((double)num1, (int)num2)).ToString();
                else if (num1 is int && num2 is double)
                    txtInput.Text = (calc.sub((int)num1, (double)num2)).ToString();
                else if (num1 is int && num2 is int)
                    txtInput.Text = (calc.sub((int)num1, (int)num2)).ToString();
            }
                
            else if (input.Contains("*"))
            {
                if (num1 is double && num2 is double)
                    txtInput.Text = (calc.mult((double)num1, (double)num2)).ToString();
                else if (num1 is double && num2 is int)
                    txtInput.Text = (calc.mult((double)num1, (int)num2)).ToString();
                else if (num1 is int && num2 is double)
                    txtInput.Text = (calc.mult((int)num1, (double)num2)).ToString();
                else if (num1 is int && num2 is int)
                    txtInput.Text = (calc.mult((int)num1, (int)num2)).ToString();
            }
                
            else if (input.Contains("/"))
            {
                if (num1 is double && num2 is double)
                    txtInput.Text = (calc.div((double)num1, (double)num2)).ToString();
                else if (num1 is double && num2 is int)
                    txtInput.Text = (calc.div((double)num1, (int)num2)).ToString();
                else if (num1 is int && num2 is double)
                    txtInput.Text = (calc.div((int)num1, (double)num2)).ToString();
                else if (num1 is int && num2 is int)
                    txtInput.Text = (calc.div((int)num1, (int)num2)).ToString();
            }
                
        }

        private void btnDex2Hex_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            
            
            if (input.Contains("+"))
            {
                MessageBox.Show("No +");
                txtInput.Clear();
            }
           else if (input.Contains("-"))
            {
                MessageBox.Show("No -");
                txtInput.Clear();
            }
            else if (input.Contains("*"))
            {
                MessageBox.Show("No *");
                txtInput.Clear();
            }
            else if (input.Contains("/"))
            {
                MessageBox.Show("No /");
                txtInput.Clear();
            }

            if(txtInput.Text != "")
            txtInput.Text = int.Parse(input).ToString("X");  //The X represents the hexadecimal conversion
        }

        private void btnHex2Dec_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (input.Contains("+"))
            {
                MessageBox.Show("No +");
                txtInput.Clear();
            }
            else if (input.Contains("-"))
            {
                MessageBox.Show("No -");
                txtInput.Clear();
            }
            else if (input.Contains("*"))
            {
                MessageBox.Show("No *");
                txtInput.Clear();
            }
            else if (input.Contains("/"))
            {
                MessageBox.Show("No /");
                txtInput.Clear();
            }


                if (txtInput.Text != "")
                txtInput.Text = Convert.ToInt32(input, 16).ToString();   //The 16 represents the hexadecimal (UTF-16)
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }
    }
}

