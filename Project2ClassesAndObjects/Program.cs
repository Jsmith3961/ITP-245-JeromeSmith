using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Project2ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ronald's Part's, How many parts will you add?");
            var parts = new List<Part>();
            var partCount = Convert.ToInt16(Console.ReadLine());
            var count = 0; Part part = null;
            while (count < partCount)
            {
                count++;
                Console.WriteLine($"\nEnter the Part Number for Part Number {count}");
                var partNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nEnter the Name for Part Number {partNumber}");
                var name = Console.ReadLine();
                Console.WriteLine($"\nEnter the Description for Part Number {partNumber}");
                var description = Console.ReadLine();
                Console.WriteLine($"\nEnter the Quantity for Part Number {partNumber}");
                var quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nEnter the cost for Part Number {partNumber}");
                var cost = Convert.ToDouble(Console.ReadLine());
                part = new Part (partNumber, quantity, cost, name, description, count );
                parts.Add(part);

            }
            Part[] partArray = parts.ToArray();
            Console.WriteLine("\n\nWhich part do you want to view? Enter the part number.");
            for (int i = 0; i < partArray.Length; i++)
                Console.WriteLine($"{partArray[i].PartNumber}\t{partArray[i].Name}");
                var partNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < partNum; i++)
            {
                if (partArray[i].PartNumber == partNum)
                {

                    part = partArray[i];
                    break;
                }
                Console.WriteLine($"{part.Display()}");
                Console.ReadKey();
            }

        }
    }
}
