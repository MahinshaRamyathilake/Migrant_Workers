using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class EmbassyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
