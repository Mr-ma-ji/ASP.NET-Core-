using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    //创建上下文对象类
    public class ShopContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        //重写方法设置数据库连接字符串
        protected override void OnConfiguring(DbContextOptionsBuilder db) {
            db.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopDB;integrated security=true"
                );
        }
    }
}
