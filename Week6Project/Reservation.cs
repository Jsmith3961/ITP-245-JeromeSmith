using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week6Project
{
    internal class Reservation
    {
        int rID;
        double date;
        string lName, fName, destination;

        public int ReservationID


        {
            get { return rID; }
            set { rID = value; }
        }

        public double Date
        { 
            
            get { return date; } 
            set { date = value; } 
        }
        
        public string LName
        {
            get { return lName; }
            set { lName = value; } 
        
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        
        }


        public string Destination
        {
            get { return destination; }
            set { destination = value; }

        }


    }
}
