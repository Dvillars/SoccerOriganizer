using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerOrganizer.Models;



namespace SoccerOrganizer.Models.Controllers
{
    public class DivisionsController : Controller
    {
        private SoccerOrganizerContext db = new SoccerOrganizerContext();
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Division division)
        {
            db.Divisions.Add(division);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
