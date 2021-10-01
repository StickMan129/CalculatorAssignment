using System;
using CalcLibrary;
namespace CalculatorCLI
{
    class Program
    {

        static object num1;
        static object num2;

        static void Main(string[] args)
        {
            CalculatorFunctions calc = new CalculatorFunctions();

            try { num1 = double.Parse(args[1]); } catch { }
            try { num2 = double.Parse(args[2]); } catch { }

            try { num1 = int.Parse(args[1]); } catch { }
            try { num2 = int.Parse(args[2]); } catch { }

            Console.WriteLine("/?");

                switch (args[0])
                {
                    case "/add":
                        if (num1 is double && num2 is double)
                           Console.WriteLine(calc.add((double)num1, (double)num2));
                        else if (num1 is double && num2 is int)
                           Console.WriteLine(calc.add((double)num1, (int)num2));
                        else if (num1 is int && num2 is double)
                           Console.WriteLine(calc.add((int)num1, (double)num2));
                        else if (num1 is int && num2 is int)
                           Console.WriteLine(calc.add((int)num1, (int)num2));
                        break;

                    case "/sub":
                        if (num1 is double && num2 is double)
                            Console.WriteLine(calc.sub((double)num1, (double)num2));
                        else if (num1 is double && num2 is int)
                            Console.WriteLine(calc.sub((double)num1, (int)num2));
                        else if (num1 is int && num2 is double)
                            Console.WriteLine(calc.sub((int)num1, (double)num2));
                        else if (num1 is int && num2 is int)
                            Console.WriteLine(calc.sub((int)num1, (int)num2));
                        break;

                    case "/div":
                        if (num1 is double && num2 is double)
                            Console.WriteLine(calc.div((double)num1, (double)num2));
                        else if (num1 is double && num2 is int)
                            Console.WriteLine(calc.div((double)num1, (int)num2));
                        else if (num1 is int && num2 is double)
                            Console.WriteLine(calc.div((int)num1, (double)num2));
                        else if (num1 is int && num2 is int)
                            Console.WriteLine(calc.div((int)num1, (int)num2));
                        break;

                    case "/mult":
                        if (num1 is double && num2 is double)
                            Console.WriteLine(calc.mult((double)num1, (double)num2));
                        else if (num1 is double && num2 is int)
                            Console.WriteLine(calc.mult((double)num1, (int)num2));
                        else if (num1 is int && num2 is double)
                            Console.WriteLine(calc.mult((int)num1, (double)num2));
                        else if (num1 is int && num2 is int)
                            Console.WriteLine(calc.mult((int)num1, (int)num2));
                        break;

                    case "/dec2hex":
                       Console.WriteLine(calc.dec2hex(int.Parse(args[1])));
                        break;

                    case "/hex2dec":
                       Console.WriteLine(calc.hex2dec(args[1]));
                        break;

                    case "/?":
                        Console.WriteLine(" The following commands you can use are: /add | /sub | /div | /mult | /dec2hex | /hex2dec");
                        break;
                }
            

        }
    }
}
