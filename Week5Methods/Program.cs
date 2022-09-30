using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week5Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c, d;   
            a = MagicNumber();
            b = MagicNumber();
            c = localTaxRate();
            d = localTaxRate();    
            welcomeMessage();
            GetArea(a,b);
            ReadKey();
        }

        static void welcomeMessage()
        {
            
            Console.WriteLine("Welcome to my Method Examples");
        }

        static int MagicNumber()
        {

            int secretNumber;
            secretNumber = 8;
            return secretNumber;
            Console.WriteLine("Your secret number is {0}", secretNumber);
        }


        static void GetArea(int length, int width)

        {
            int total = length * width;
            Console.WriteLine("Your total is {0}" ,total);
        }

        static int localTaxRate()
        {
            int x;
            Console.WriteLine("Please enter your tax rate");
            x = Convert.ToInt32(Console.ReadLine());
            return x;



        }

    }
}
