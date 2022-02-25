using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGitCheck.Models;

namespace WebAppGitCheck.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public ActionResult Index()
        {
            List<Player> playerList = new List<Player>
            { 
                new Player{PId=1,PName="MSD",PTeam="CSK"},
                new Player{PId=2,PName="Virat",PTeam="RCB"},
            };
            return View(playerList);
        }
    }
}