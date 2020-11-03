using System;
using StackExchange.Redis;
using Newtonsoft.Json;
namespace RedisOrStackExchange.Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库
            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase db = connection.GetDatabase(6);
            //Student stu = new Student();
            //stu.stuId = 1;
            //stu.age = 20;
            //stu.stuName = "马老板";
            //string st = JsonConvert.SerializeObject(stu);
            //if (db.StringSet("stu", st))
            //{
            //    Console.WriteLine((JsonConvert.DeserializeObject<Student>(db.StringGet("stu"))).stuId);
            //    Console.WriteLine((JsonConvert.DeserializeObject<Student>(db.StringGet("stu"))).stuName);
            //    Console.WriteLine((JsonConvert.DeserializeObject<Student>(db.StringGet("stu"))).age);
            //}
            if (db.KeyDelete("stu"))
            {
                Console.WriteLine((JsonConvert.DeserializeObject<Student>(db.StringGet("stu"))).stuId);
                Console.WriteLine((JsonConvert.DeserializeObject<Student>(db.StringGet("stu"))).stuName);
                Console.WriteLine((JsonConvert.DeserializeObject<Student>(db.StringGet("stu"))).age);
            }
            //db.StringSet("ce","保存测试！");
            //Console.WriteLine("保存成功！");
            //Console.WriteLine("数据为:" + db.StringGet("ce"));
            //if (db.KeyDelete("ce"))
            //{
            //    Console.WriteLine("删除成功");
            //    Console.WriteLine("尝试输出:" + db.StringGet("ce"));
            //}
           
        }
    }
}
