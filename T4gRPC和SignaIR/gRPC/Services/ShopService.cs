using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;

namespace MyShop
{
    public class ShopService:PorductManager.PorductManagerBase
    {
        //数据库连接字符串
        private readonly string connstring = "server=(localdb)\\MSSQLLocalDB;database=ShopDB;integrated security=true";
        //根据id查询一个商品
        public override Task<ProductResponse> GetProductByID(ProductRequest request,ServerCallContext context) {
            var result = new ProductResponse();
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string sql = string.Format("select * from Product where ProductID={0}",request.Id);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result.Product = new Product {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        ProductPrice = reader.GetInt32(2),
                        CategoryID = reader.GetInt32(3),
                    };
                }
                conn.Close();
            }
            return Task.FromResult(result);
        }
        //查询全部商品
        public override Task<ProductListResponse> GetProductList(Emty request, ServerCallContext context)
        {
            var result = new ProductListResponse();
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string sql = string.Format("select * from Product");
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product  product= new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        ProductPrice = reader.GetInt32(2),
                        CategoryID = reader.GetInt32(3),
                    };
                    result.Products.Add(product);
                }
                conn.Close();
            }
            return Task.FromResult(result);
        }
    }
}
