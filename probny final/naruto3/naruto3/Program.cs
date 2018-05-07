using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace naruto3
{
    class Program
    {
        static void File(int cur , FileSystemInfo[] obshy)
        {
            Console.Clear();
            for (int i = 0; i < obshy.Length; i++)
            {
                if (cur == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(obshy[i].Name);
            }
            
        }
        static void Main(string[] args)
        {
            int cur = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user\Desktop\PP2Lab");
            FileSystemInfo[] obshy = directory.GetFileSystemInfos();
            File(cur, obshy);
            while (true)
            {
                
                ConsoleKeyInfo btn = Console.ReadKey();
                if (btn.Key == ConsoleKey.UpArrow)
                {
                    cur--;
                    if (cur == -1)
                        cur = obshy.Length - 1;
                }
                if (btn.Key == ConsoleKey.DownArrow)
                {
                    cur++;
                    if (cur == obshy.Length)
                        cur = 0;
                }
                if (btn.Key == ConsoleKey.Enter)
                {
                    if (obshy[cur].GetType() == typeof(DirectoryInfo))
                    {
                        cur = 0;
                        directory = new DirectoryInfo(obshy[cur].FullName);
                        obshy = directory.GetFileSystemInfos();
                    }
                    else
                    {
                        Console.Clear();
                        StreamReader s = new StreamReader(obshy[cur].FullName);
                        Console.WriteLine(s.ReadToEnd());
                        Console.ReadKey();
                    }
                }
                if (btn.Key == ConsoleKey.Backspace || btn.Key == ConsoleKey.Escape)
                {
                    directory = directory.Parent;
                    obshy = directory.GetFileSystemInfos();
                }
                File(cur, obshy);
            }
        }
    }
}
