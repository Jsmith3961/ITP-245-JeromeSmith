using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project3OOP
{
    internal class Person
    {
       public Person(int pID, string fName, string homeTown)
        {
           PersonID = pID;
           FullName = fName;
           HomeTown = homeTown;



        }

        public int PersonID { get; set; }
        public string FullName { get; set; }

        public string HomeTown { get; set; }

        public string Display()
        {
            return $"\nFullName:\t\t{FullName}" +
                $"\nDescription:\t{HomeTown}" +
                $"\nPersonID\t\t{PersonID}";
            
              



        }
    }
}
