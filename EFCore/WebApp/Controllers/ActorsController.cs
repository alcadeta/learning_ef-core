using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ActorsController : Controller
    {
        private efcoreconsoleContext _context;

        public ActorsController(efcoreconsoleContext context) =>
            _context = context;

        public IActionResult Index() =>
            View(_context.Actors.ToList());

        public IActionResult Create() =>
            View();

        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);
            _context.Actors.Add(actor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}