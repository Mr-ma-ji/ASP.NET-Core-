using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2_IoC.Model;

namespace T2_IoC.Models
{
    //定义一个接口
      public interface IStudent
     {
        IEnumerable<student> getstu();
     }
}
