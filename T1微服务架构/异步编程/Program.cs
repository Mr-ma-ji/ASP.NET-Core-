using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步编程
{
    class Program
    {
        static void Main(string[] args)
        {
            CallWithAsync("七七");
            //等待用户输入（因为简化版的任务未添加等待）
            Console.ReadKey();
        }
        //创建任务
        static Task<string> GeetingAsync(string name) {
            //使用run方法直接运行和初始化
            return Task.Run<string>(()=>{
                Thread.Sleep(5000);
                return string.Format("您好{0}", name);
            });
        }
        //任务调用（必须使用async关键字修饰）
        async static void CallWithAsync(string name) {
            //将任务返回的值赋值给变量
            string res = await GeetingAsync(name);
                Console.WriteLine(res);
        }
    }
}
