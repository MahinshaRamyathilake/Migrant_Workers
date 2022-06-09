using MigrationWorkersWeb.Data;
using MigrationWorkersWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class EmbassyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmbassyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var embassies = _db.Embassies;
            return View(embassies);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Embassy obj)
        {
            if (ModelState.IsValid)
            { 
                _db.Embassies.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Embassy Created Successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
