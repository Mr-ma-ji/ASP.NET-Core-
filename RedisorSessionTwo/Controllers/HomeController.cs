using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedisorSessionTwo.Models;

namespace RedisorSessionTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string username = HttpContext.Session.GetString("use");
            if (string.IsNullOrEmpty(username))
            {
                //重定向到login
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.username = username;
                ViewBag.usertime = HttpContext.Session.GetString("usertime");
                return View();
            }
           
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LoginInfo(string username,string psw)
        {
            if (username=="admin"&& psw=="1")
            {
                HttpContext.Session.SetString("use", username);
                HttpContext.Session.SetString("usertime",DateTime.Now.ToString());
                return RedirectToAction("Index");
            }
            else
            {
                return View("Login");
            }
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
