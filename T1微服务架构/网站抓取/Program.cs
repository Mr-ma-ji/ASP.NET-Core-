using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace 网站抓取
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入网址");
            CallBackMethod(Console.ReadLine());
            Console.ReadKey();
        }
        static Task<int> DownLoadPage(string url) {
            return Task.Run(async()=> {
                var ciient = new HttpClient();
                Console.WriteLine("获取中。。。。。。");
                byte[] content = await ciient.GetByteArrayAsync(url);
                Console.WriteLine("获取完毕");
               return content.Length;
                ///return content;
            });
        }
       async  static void CallBackMethod(string url) {
            var res = await DownLoadPage(url);
            Console.WriteLine("总共从{0}，下载了{1}B", url, res);
        } 
    }
}
