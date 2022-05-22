using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class EmbassyUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
