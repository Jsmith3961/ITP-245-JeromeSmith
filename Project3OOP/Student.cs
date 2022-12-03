using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3OOP
{
    internal class Student : Person
    {

        public Student(int pID, string fName, string homeTown, string major, string advisor) : base(pID, fName, homeTown)
        {
            major = Major;
            advisor = Advisor;
        }
        public string Major { get; set; }
        public string Advisor { get; set; }

        public string Display()
        {
            return $"\nMajor:\t\t{Major}" +
                $"\nAdvisor:\t{Advisor}";
        }


        }
    }
