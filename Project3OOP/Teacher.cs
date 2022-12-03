using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3OOP
{
    internal class Teacher : Person
    {
        public Teacher (int pID, string fName, string homeTown, int yearsOfService, double salary) : base(pID, fName, homeTown)
        {
            yearsOfService = YearsOfService;
            salary = Salary;
        }
        public int YearsOfService { get; set; }
        public double Salary { get; set; }

        public string Display()
        {
            return $"\nSalary:\t\t{Salary}" +
                $"\nYearsOfService:\t{YearsOfService}";
        }
    }
}
