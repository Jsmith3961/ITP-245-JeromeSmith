using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week2Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double subtotal;
            double total;
            string inputString;
            WriteLine("Hello! This application is used to calculate your repair shop bill.");
            WriteLine("Please enter the total for an oil change.");
            inputString = ReadLine();
            a = Convert.ToDouble(inputString);
            WriteLine("Please enter the total for tires.");
            b = Convert.ToDouble(ReadLine());
            WriteLine("Please enter the total for inspection.");
            c = Convert.ToDouble(ReadLine());
            subtotal = a + b + c;
            WriteLine();
            WriteLine("Your subtotal is {0}", subtotal.ToString("C"));
            total = subtotal + 0.06;
            WriteLine();
            WriteLine("Your total is {0}", total.ToString("C"));
            ReadKey();
        }
    }
}
