using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopContext shop = new ShopContext();
            Product product = new Product();
            product.ProductName = "小王";
            product.ProductPrice = 20;
            shop.Add(product);
          int a =   shop.SaveChanges();
            Console.WriteLine("添加成功"+a);
        }
    }
}
