using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreGetJison.Models;
using Microsoft.Extensions.Configuration;

namespace CoreGetJison.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //声明全局变量用来接收配置文件里的值
        IConfiguration _Configuration;
        //使用依赖注入将配置文件注入进控制器
        public HomeController(ILogger<HomeController> logger, IConfiguration Configuration)
        {
            //全局变量接受
               _Configuration = Configuration;
               _logger = logger;
            _logger.LogInformation("获取IConfiguration 和logger对象");
        }

        public IActionResult Index()
        {
            _logger.LogWarning("绑定配置项");

            site site = _Configuration.GetSection("site").Get<site>();
            return View(site);
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
