using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class AgencyAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
