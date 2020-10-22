using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T2_IoC.Model;
using T2_IoC.Models;

namespace T2_IoC.Controllers
{
    public class MyController : Controller
    {
        IStudent _student;
        public MyController(IStudent student) {
            _student = student;
        }
        public IActionResult Index()
        {
            List<student> students = _student.getstu().ToList();
            return View(students);
        }
    }
}
