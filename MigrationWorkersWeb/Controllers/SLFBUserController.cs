using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class SLFBUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
