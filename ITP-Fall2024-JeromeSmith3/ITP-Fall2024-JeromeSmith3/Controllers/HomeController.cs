using ITP_Fall2024_JeromeSmith3.Models;
using ITP245_Agile_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITP_Fall2024_JeromeSmith3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { using (var entities = new AgileEntities())
            {
               var homePage = new Dictionary<string, List<Object>>();
                var projects = entities
                .Projects
                .OrderBy(p => p.Name)
                .ToList<IAgile>();
                var students = entities
                .Students
                .ToList<IAgile>();
                return View();
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Jerome's application description page.";
            var about = new About();
            return View(about);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jerome's contact page.";
            var contact = new Contact();
            return View(contact);
        }
    }
}