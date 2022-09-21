using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week4ObjectandLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food fd1 = new Food();
            Food fd2 = new Food();

            fd1.FoodID = 1;
            fd1.Name = "Pizza";
            fd1.Cost = 15.00;
            fd1.Description = "A no topping cheese pizza.";

            fd2.FoodID = 2;
            fd2.Name = "Cheeseburger";
            fd2.Cost = 10.00;
            fd2.Description = "An ordinary Cheeseburger.";


            WriteLine("{0,10}{1,10}{2,10}{3,10}", "Food #", "Name", "Cost", "Description");
            WriteLine("{0,10}{1,10}{2,10}{3,10}", fd1.FoodID, fd1.Name, fd1.Cost, fd1.Description);
            WriteLine("{0,10}{1,10}{2,10}{3,10}", fd2.FoodID, fd2.Name, fd2.Cost, fd2.Description);


        }
    }
}
