using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_api2.Model;

namespace My_api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public List<student> Get()
        {
            List<student> students = new List<student>() {
                new student{stuid=1,stuage=20,stuname="小王" ,stusex="男"},
                 new student{stuid=2,stuage=22,stuname="小李" ,stusex="女"},
                  new student{stuid=3,stuage=21,stuname="小陈" ,stusex="女"},
                   new student{stuid=4,stuage=23,stuname="小马" ,stusex="男"}
            };
            return students;
        }
    }
}
