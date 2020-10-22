using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2_IoC.Model;

namespace T2_IoC.Models
{
    public class GetStudent : IStudent
    {
        public IEnumerable<student> getstu()
        {
            return new List<student> {
                new student{stuid=1,stuage=20,stuname="小王" ,stusex="男"},
                 new student{stuid=2,stuage=22,stuname="小李" ,stusex="女"},
                  new student{stuid=3,stuage=21,stuname="小陈" ,stusex="女"},
                   new student{stuid=4,stuage=23,stuname="小马" ,stusex="男"}
            };
        }
    }
}
