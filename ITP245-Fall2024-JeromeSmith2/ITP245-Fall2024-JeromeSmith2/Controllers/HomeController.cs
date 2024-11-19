using ITP245_Agile_Model;
using ITP245_Fall2024_JeromeSmith2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITP245_Fall2024_JeromeSmith2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   using (var entities = new AgileEntities())
            {
                var homePage = new Dictionary<string, List<Object>>();
                var projects = entities
                .Projects
                .OrderBy(p => p.Name)
                .ToList<IAgile>();
                var students = entities
                .Students
                .ToList<IAgile>();
                homePage.Add("Current Projects", projects);
                homePage.Add("Students", students);
                return View(homePage);
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Jerome's About Page.";
            var about = new About();
            return View(about);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jerome's Contact Page.";
            var contact = new Contact();
            return View(contact);
        }
    }
}