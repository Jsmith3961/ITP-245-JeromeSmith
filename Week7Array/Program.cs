using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week7Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] company = new string[3];
            string[] model = new string[3];
            double[] cost = new double[3];

            for (int x = 0; x < model.Length; ++x)
            {
                WriteLine("Please enter the company {0}", company[x]);
                company[x] = Convert.ToString(ReadLine());
                WriteLine("Please enter the model for {0}", company[x]);
                model[x] = Convert.ToString(ReadLine());
                WriteLine("Please enter the price for {0}", company[x]);
                cost[x] = Convert.ToDouble(ReadLine());


            }

            for (int y = 0; y < cost.Length; ++y)
            { 
                WriteLine("{0,10}{1,15}{2,20}", "COMPANY", "MODEL" ,"COST");
                WriteLine("{0,10}{1,15}{2,20}", company[y], model[y], cost[y]);
                
            }

            double m = cost.Max();
            int p = Array.IndexOf(cost, m);
            WriteLine(company[p] + "has the highest costing car.");
            ReadKey();
        }
    }
}
