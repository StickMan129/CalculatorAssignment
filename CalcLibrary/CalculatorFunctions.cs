using System;
using System.Collections.Generic;
using System.Text;

namespace CalcLibrary
{
   public class CalculatorFunctions
    {
        //Addition
        public int add(int a, int b)
        {
            return a + b;
        }
        public double add(int a, double b)
        {
            return a + b;
        }
        public double add(double a, int b)
        {
            return a + b;
        }
        public double add(double a, double b)
        {
            return a + b;
        }

        //Subtraction
        public int sub(int a, int b)
        {
            return a - b;
        }
        public double sub(int a, double b)
        {
            return a - b;
        }
        public double sub(double a, int b)
        {
            return a - b;
        }
        public double sub(double a, double b)
        {
            return a - b;
        }

        //Division
        public int div(int a, int b)
        {
            return a / b;
        }
        public double div(int a, double b)
        {
            return a / b;
        }
        public double div(double a, int b)
        {
            return a / b;
        }
        public double div(double a, double b)
        {
            return a / b;
        }

        //Multiplication
        public int mult(int a, int b)
        {
            return a * b;
        }
        public double mult(int a, double b)
        {
            return a * b;
        }
        public double mult(double a, int b)
        {
            return a * b;
        }
        public double mult(double a, double b)
        {
            return a * b;
        }

       public int dec2hex(int a)
        {
            a.ToString("X");
            return a;
        }

        public string hex2dec(string a)
        {
            Convert.ToInt32(a, 16).ToString();
            return a;
        }



    }
}
