using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName{ get; set; }
        public int ProductPrice { get; set; }
        //商品类别外键对象
        public Category Category { get; set; }
    }
    public class Category {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        //该类别商品集合导航属性
        public ICollection<Product> Products { get; set;}
    }
}
