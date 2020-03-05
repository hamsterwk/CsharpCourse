using System;

namespace H2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"请输入一个数：");
            string buf = Console.ReadLine();
            int num = int.Parse(buf);
            Console.WriteLine("以下为"+num+"的全部素因子：");
            for (int i = 2; i <= num; i++)
            {
                if (num % i != 0) continue;
                Console.WriteLine(i);
                while (num % i == 0)
                {
                    num /= i;
                }
            }
        }
    }
}
