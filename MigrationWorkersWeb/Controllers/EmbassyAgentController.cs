using Microsoft.AspNetCore.Mvc;

namespace MigrationWorkersWeb.Controllers
{
    public class EmbassyAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
