using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class AgencyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
