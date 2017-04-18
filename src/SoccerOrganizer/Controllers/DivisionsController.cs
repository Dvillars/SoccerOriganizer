using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerOrganizer.Models;
using Microsoft.EntityFrameworkCore;


namespace SoccerOrganizer.Controllers
{
    public class DivisionsController : Controller
    {
        private SoccerOrganizerContext db = new SoccerOrganizerContext();
        public IActionResult Index()
        {
            return View(db.Divisions.ToList());
        }

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

        public IActionResult Edit(int id)
        {
            var thisItem = db.Divisions.FirstOrDefault(divisions => divisions.DivisionId == id);
            return View(thisItem);
        }

        [HttpPost]
        public IActionResult Edit(Division division)
        {
            db.Entry(division).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
