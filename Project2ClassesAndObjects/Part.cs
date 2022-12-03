using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project2ClassesAndObjects
{
    internal class Part
    {

        int partNum, quantity;
        double cost, value;
        string name, description;

        public int PartNumber
        {
            get; 
            set;
        }
        
        public double Cost
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public double Value
        {
            get { return Cost * quantity; }
        }

        public Part() { }
        public Part(int partNum, int quantity, double cost, string name, string description, int partNumber)

        { 
            Description = description;
            PartNumber = partNumber;
            Cost = cost;
            Quantity = quantity;
            Name = name; 
        }
        public string Display()
        {
            return $"\nNumber:\t\t{partNum}" +
                $"\nName:\t\t{name}" +
                $"\nDescription:\t{description}" +
                $"\nQuantity:\t{Quantity}" +
                $"\nCost:\t\t{Cost:c}" +
                $"\nValue:\t\t{Value:c}";



        }
        }
    }
