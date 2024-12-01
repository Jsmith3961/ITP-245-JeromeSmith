using ITP_Fall2024_JeromeSmith4.Models;
using ITP245_Sports_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITP_Fall2024_JeromeSmith4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   using (var entities = new SportsEntities())
            {
                var homepage = new Dictionary<string, List<ISports>>();
                var teams = entities
                .Teams
                .OrderBy(p => p.Name)
                .ToList<ISports>();
                var players = entities
                .Players
                .ToList<ISports>();
                homepage.Add("Teams", teams);
                homepage.Add("Players", players);
                return View(homepage);
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
            return View();
        }
    }
}