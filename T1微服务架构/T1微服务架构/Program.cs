
using System;

namespace T1微服务架构
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fistType = new string[] { "石头", "布", "剪刀" };
            Console.WriteLine("*************趣味猜拳游戏*************");
            Console.WriteLine("请输入您的出拳数字（1-石头，2-布，3-剪刀，4-退出）");
            string inputFirst = Console.ReadLine();
            while (inputFirst != "4")
            {
                //电脑随机出拳
                Random random = new Random();
                int computerFirst = (int)random.Next(1, 3);
                try
                {
                    int presonFist = Convert.ToInt32(inputFirst);
                    if (presonFist > 0 && presonFist < 5)
                    {
                        if (presonFist< computerFirst)
                        {
                            if (presonFist == 1 && computerFirst == 3)
                            {
                                Console.WriteLine("你出了{0},电脑出了{1}，结果你赢了！", fistType[presonFist - 1], fistType[computerFirst - 1]);
                            }
                            else
                            {
                                Console.WriteLine("你出了{0},电脑出了{1}，结果电脑赢了！", fistType[presonFist - 1], fistType[computerFirst - 1]);
                            }
                        }
                        else if (presonFist == computerFirst)
                        {
                            Console.WriteLine("你出了{0},电脑出了{1}，结果你和电脑平局！", fistType[presonFist - 1], fistType[computerFirst - 1]);
                        }
                        else
                        {
                            if (presonFist == 3 && computerFirst == 1)
                            {
                                Console.WriteLine("你出了{0},电脑出了{1}，结果电脑赢了！", fistType[presonFist - 1], fistType[computerFirst - 1]);
                            }
                            else
                            {
                                Console.WriteLine("你出了{0},电脑出了{1}，结果你赢了！", fistType[presonFist - 1], fistType[computerFirst - 1]);
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("您的数字输入有误请重新输入......");
                    }
                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("*************趣味猜拳游戏*************");
                Console.WriteLine("请输入您的出拳数字（1-石头，2-布，3-剪刀，4-退出）");
                inputFirst = Console.ReadLine();

            }
        }
    }
}
 