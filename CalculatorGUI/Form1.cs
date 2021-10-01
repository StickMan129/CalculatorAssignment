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
            txtInput.Text += m;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (input.Contains("+"))
            {

            }
                
            else if (input.Contains("-"))
            {

            }
                
            else if (input.Contains("*"))
            {

            }
                
            else if (input.Contains("/"))
            {

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

