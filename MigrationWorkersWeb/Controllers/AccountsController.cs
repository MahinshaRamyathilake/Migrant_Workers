using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Web;
using System.Linq;
using MigrationWorkersWeb.Models;
using MigrationWorkersWeb.Data;
using Microsoft.AspNetCore.Authentication;

namespace MigrationWorkersWeb.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login credentials)
        {
            bool userExist = _db.Users.Any(u => u.UserName == credentials.UserName && u.Password == credentials.Password);
            User user = _db.Users.FirstOrDefault(u => u.UserName == credentials.UserName && u.Password == credentials.Password);

            if (userExist)
            {
                HttpContext.SignInAsync();
            }
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User obj)
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
