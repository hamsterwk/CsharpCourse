using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace H2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\\prog C#\\test");
            FileInfo[] inf = dir.GetFiles();
            foreach(FileInfo finf in inf)
            {
                FileStream stream = finf.OpenRead();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                for(string text = reader.ReadLine();text!=null;text = reader.ReadLine())
                {
                    Console.Write(text + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
