using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ITP245_Fall2024_JeromeSmith2.Models
{
    public class About
    {
        

            public string Name { get; set; }

            public string Email { get; set; }

            public string Hometown { get; set; }

            public string Major { get; set; }

            public string Education { get; set; }

            public List<string> Experience { get; private set; }

            public About()
            {
                Name = "Jerome Smith";
                Email = "jhs39612@email.vccs.edu";
                Hometown = "Paterson, New Jersey";
                Major = "Computer Science";
                Education = "High School Diploma.";
                Experience = new List<string>() { "Richmond Restore Center", "Dominos Pizza" };
            }
        }
    }
