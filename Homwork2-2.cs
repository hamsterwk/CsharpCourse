using System;

namespace H2T2
{
    class Program
    {
        static double[] dealArray(int[] num)
        {
            double[] rtn = new double[4];
            //{max,min,sum,ave}
            rtn[0] = -1e9;rtn[1] = 1e9;
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] > rtn[0]) rtn[0] = num[i];
                if (num[i] < rtn[1]) rtn[1] = num[i];
                rtn[2] += num[i];
                rtn[3] += num[i];
            }
            rtn[3] /= num.Length;
            return rtn;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字个数：");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int n)&& n>=0)
            {
                int[] num = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("请输入第" + (i+1)+ "个数：");
                    s = Console.ReadLine();
                    try
                    {
                        num[i] = int.Parse(s);
                    }
                    catch
                    {
                        Console.WriteLine("第" + i + "个数输入非法！请重新输入！");
                        i--;
                    }
                    
                }

                double[] ans = dealArray(num);
                Console.Write("最大值：{0}，最小值：{1}，总和：{2}，平均值：{3}", ans[0], ans[1], ans[2], ans[3]);
            }
            else
            {
                Console.Write("输入非法！请重新输入！");
            }
        }
    }
}
