using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerOrganizer.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SoccerOrganizer.Controllers
{
    public class TeamsController : Controller
    {
        private SoccerOrganizerContext db = new SoccerOrganizerContext();
        public IActionResult Index()
        {
            return View(db.Teams.ToList());
        }
    }
}
