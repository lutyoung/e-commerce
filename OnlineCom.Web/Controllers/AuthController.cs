using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(int id)
        {
            id = 9;
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return RedirectToAction("Customer", "Index");
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
