using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RedisOrSession.Controllers
{
    public class RedisOrSessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("time",DateTime.Now.ToString());
            return View();
        }
        public IActionResult indexOf()
        {
            ViewBag.sess = HttpContext.Session.GetString("time");
            return View("Index");
        }
        public IActionResult remove()
        {
            HttpContext.Session.Remove("time");
            return View("Index");
        }
    }
}
