using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week6Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reservation r1 = new Reservation();
            int a, b;
            


            r1.ReservationID = 2125;
            r1.LName = "Smith";
            r1.FName = "Jerome";
            r1.Date = 09/10/22;
            r1.Destination = "Spain";

            a = baggageTotal();
            b = baggageTotal();


        }

        static int baggageTotal()
        {
            int x;
            int total;
            WriteLine("Please enter number of bags.");
            x = Convert.ToInt32(Console.ReadLine());
            total = x * 25; 
            return total;


        }

    }
}
