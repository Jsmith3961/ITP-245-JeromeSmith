using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using ITP245_Sports_Model;

namespace ITP_Fall2024_JeromeSmith4.Controllers
{
    public class GameController : Controller
    {
        private SportsEntities db = new SportsEntities(); 
        // GET: Task
        public ActionResult Index()
        {
            var games = db.Games
            .OrderBy(g => g.HomeTeamID)
            .ThenBy(g => g.DateTime)
            .ToList();
            return View(games);
        }
    }
}