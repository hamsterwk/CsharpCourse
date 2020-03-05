using System;

namespace H2T3
{
    class Program
    {
        static int inputInt()
        {
            while (true)
            {
                string s = Console.ReadLine();
                try
                {
                    int rtn = int.Parse(s);
                    return rtn;
                }
                catch
                {
                    Console.WriteLine("输入非法，请重新输入！");
                }
            }
        }
        static void getPrime(int n)
        {
            int cntPrime = 0;
            int[] prime = new int[n+1];
            bool[] flag = new bool[n+1];
            for(int i = 2; i <= n; i++)
            {
                if (!flag[i])
                {
                    prime[cntPrime] = i;
                    cntPrime++;
                    Console.WriteLine(i);
                }
                for(int j = 0; j < cntPrime && i * prime[j] <= n; j++)
                {
                    flag[i * prime[j]] = true;
                    if (i % prime[j] == 0) break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入预处理的数的范围：");
            int n = inputInt();
            while (n <= 0)
            {
                Console.WriteLine("你输入了一个不合法的数！请重新输入！");
                n = inputInt();
            }
            Console.WriteLine("以下为"+n+"以内的质数：");
            getPrime(n);
        }
    }
}
