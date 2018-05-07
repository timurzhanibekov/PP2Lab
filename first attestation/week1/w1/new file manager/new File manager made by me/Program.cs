using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace new_File_manager_made_by_me
{
    class Program
    {
        static void Main(string[] args)
        {
            int cur = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user\Desktop\PP2Lab\week2");
            DirectoryInfo[] ds = directory.GetDirectories();
            FileInfo[] fs = directory.GetFiles();
            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.UpArrow)
                {
                    cur--;
                    if (cur == -1)
                        cur = fss.Length;
                }
                if (k.Key == ConsoleKey.DownArrow)
                {
                    cur++;
                    if (cur == fss.Length)
                        cur = 0;
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    if(fss[cur].GetType() == typeof(DirectoryInfo))
                    {
                        cur = 0;
                        directory = new DirectoryInfo(fss[cur].FullName);
                        fss = directory.GetFileSystemInfos();
                    }
                    else
                    {
                        Console.Clear();
                        StreamReader sr = new StreamReader(fss[cur].FullName);
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();
                    }
                }

            }
        }
    }
}
