using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double option, a, b, c, d, e, f, total;
            WriteLine("Please select an option between a.(Sick Appointment) or b.(Check Up)");
            a = Convert.ToDouble(ReadLine());
            b = Convert.ToDouble(ReadLine());
            option = Convert.ToDouble(ReadLine());
            switch(option)

            { case 1: total =  a;
                    WriteLine("You've selected Sick Appointment.");

                    break;

                case 2: total = b;
                    WriteLine("You've selected Check Up.");
                    break;

                default:
                    WriteLine("You did not enter a valid option.");
                    break; }


        }
    }
}
