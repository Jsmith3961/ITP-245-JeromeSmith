using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITP245_Agile_Model;

namespace ITP245_Fall2024_JeromeSmith2.Models { 
public class Contact
{

    public string Author { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Description { get; set; }

    public string Manage { get; set; }

    public List<string> Manages { get; private set; }
    public Contact()
    {
        
        using (var entities = new AgileEntities())
            {
                var systemOption = entities.SystemOptions.First();
                Author = "Jerome Smith";
            }

            Email = "jhs39612@email.vccs.edu";
        Phone = "804-386-7818";
        Description = "Reynolds Community College software management for ITP Courses.";
        Manage = "This manages both team and individual projects.";
        Manages = new List<string>() { "Tasks", "Deadlines", "Progress and", "Other issues" };
    }
  }
}