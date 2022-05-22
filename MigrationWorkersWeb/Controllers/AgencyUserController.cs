using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class AgencyUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
