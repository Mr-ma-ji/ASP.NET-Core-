using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Newtonsoft.Json;
using RedisAPPDemo.Models;

namespace RedisAPPDemo.Controllers
{
    public class MyRedisController : Controller
    {
        //rides数据库对象
        RedisCache redis;
        public MyRedisController()
        {
            //创建rides客户端对象
            RedisCacheOptions options = new RedisCacheOptions();
            options.Configuration="127.0.0.1:6379";
            //自定义连接实例的名字
            options.InstanceName = "RedisServer";
            //将实例添加到数据库对象
            redis = new RedisCache(options); 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult add()
        {
            //添加一条数据
            redis.SetString("time",DateTime.Now.ToString());
            //添加对象
            Student student = new Student() { 
                StuId=1,
                StuAge=20,
                StuName="游老板"
            };
            //将对象转换为json对象
            string stu = JsonConvert.SerializeObject(student);
            redis.SetString("stu", stu);
            ViewBag.msg = "添加成功!";
            return View("Index");
        }
        public IActionResult request()
        {
            //读取一条数据
            string duqu = redis.GetString("time");
            //读取对象(将json转换为对象存储在ViewBag中)
            if (redis.GetString("stu")!=null)
            {
                Student student = JsonConvert.DeserializeObject<Student>(redis.GetString("stu"));
                ViewBag.stu = student;
            }
            ViewBag.msg = "读取成功：" + duqu;
            return View("Index");
        }
        public IActionResult remove()
        {
            //删除一条数据
            redis.Remove("time");
            redis.Remove("stu");
            ViewBag.msg = "删除成功!";
            return View("Index");
        }
    }
}
