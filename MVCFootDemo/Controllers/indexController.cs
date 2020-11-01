using MVCFootDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVCFootDemo.Controllers
{
    public class indexController : Controller
    {
        //数据库操作对象
        public FoodDBEntities db = new FoodDBEntities();
        // GET: index
        public ActionResult Index()
        {
            //获取数据
            List<FoodList> foods = db.FoodList.ToList();
            return View(foods);
        }
        public ActionResult getType(int id)
        {
            //获取数据
            FoodType foods = db.FoodType.FirstOrDefault(x=>x.TypeID==id);
            return View(foods);
        }
        //商品添加页面
        public ActionResult addfoot()
        {
            //获取商品分类
            List<FoodType> types = db.FoodType.ToList();
            SelectList listItems = new SelectList(types, "TypeID", "TypeName","3");
            List<SelectListItem> select = new List<SelectListItem>();
            select.AddRange(listItems);
            ViewBag.select = select;
            return View();
        }
        [HttpPost]
        public ActionResult addfoot(FoodList list,HttpPostedFileBase fileimg)
        {
            if (fileimg.ContentLength>0)
            {
                fileimg.SaveAs(Server.MapPath("~/img/" + fileimg.FileName));
                list.Pic = fileimg.FileName;

            }
            db.FoodList.Add(list);
            if (db.SaveChanges()>0)
            {
                return Content("true");
            }

            return Content("false");
        }
        public ActionResult delfoot(int id)
        {

            FoodList food = db.FoodList.FirstOrDefault(x=>x.FoodID==id);
            db.FoodList.Remove(food);
            if (db.SaveChanges() > 0)
            {
                return Content("true");
            }

            return Content("false");
        }
        public ActionResult updfoot(int id)
        {
            FoodList food = db.FoodList.FirstOrDefault(x=>x.FoodID==id);
            //获取商品分类
            List<FoodType> types = db.FoodType.ToList();
            SelectList listItems = new SelectList(types, "TypeID", "TypeName", food.TypeID);
            List<SelectListItem> select = new List<SelectListItem>();
            select.AddRange(listItems);
            ViewBag.select = select;
            return View(food);
        }
    }
}