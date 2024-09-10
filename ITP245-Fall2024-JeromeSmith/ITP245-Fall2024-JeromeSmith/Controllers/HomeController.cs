using ITP245_Fall2024_JeromeSmith.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITP245_Fall2024_JeromeSmith.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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