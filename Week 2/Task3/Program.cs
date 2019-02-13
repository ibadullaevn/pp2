using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void f(DirectoryInfo dir, int j)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string s = "";
            for (int i = 0; i < j; i++)
            {
                s += " ";
            }
            Console.WriteLine(s + dir.Name);
            FileSystemInfo[] x = dir.GetFileSystemInfos();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].GetType() == typeof(DirectoryInfo))
                {
                    //Console.WriteLine("YES");
                    DirectoryInfo dir2 = x[i] as DirectoryInfo;
                    f(dir2, j + 4);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(s + x[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\Asus\Desktop\1");
            f(dirinfo, 0);
        }
    }
}