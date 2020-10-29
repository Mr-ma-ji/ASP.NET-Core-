using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbDatabaseOfCore.Models;
using Microsoft.AspNetCore.Mvc;


namespace DbDatabaseOfCore.Controllers
{
    public class ShopController : Controller
    {
        //定义全局访问对象
        ShopContext _ShopContext;
        //利用构造方法将访问对象注入到控制器
        public ShopController(ShopContext shopContex) {
            _ShopContext = shopContex;
        }

        public IActionResult Index()
        {
            List<Product> prlist = _ShopContext.Product.ToList();
            return View(prlist);
        }
        public IActionResult insertShop() {

            return View();
        }
        [HttpPost]
        public IActionResult insertShop(Product product)
        {
            _ShopContext.Product.Add(product);
            if (_ShopContext.SaveChanges()>0)
            {
                return RedirectToAction("index");
            }
            return View();
        }
        public IActionResult Remove(int id)
        {
            Product product = _ShopContext.Product.Find(id);
            if (product!=null)
            {
                _ShopContext.Product.Remove(product);
                _ShopContext.SaveChanges();
            }
           
            return RedirectToAction("index");
        }
        
    }
}
