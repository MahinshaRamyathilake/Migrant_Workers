using MigrationWorkersWeb.Data;
using MigrationWorkersWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class AgencyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AgencyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var agencies = _db.Agencies;
            return View(agencies);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Agency obj)
        {
            if (ModelState.IsValid)
            {
                _db.Agencies.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Agency Created Successfully!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
