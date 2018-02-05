using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        public static void File(int cur,FileSystemInfo[] fss)
        {
            int index = 0;
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            foreach(FileSystemInfo f in fss)
            {
                if (cur == index)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(f.Name);
                index++;
            }
        }
        static void Main(string[] args)
        {
            int cur = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user\Desktop\PP2Lab\week1");
            DirectoryInfo[] ds = directory.GetDirectories();
            FileInfo[] fs = directory.GetFiles();
            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            File(cur, fss);
            /* foreach(FileSystemInfo f in fss)
             {
                 if (f.GetType() == typeof(DirectoryInfo))
                 {
                     Console.WriteLine("Directory : " + f.Name);
                 }
                 else
                 {
                     Console.WriteLine("File : " + f.Name);
                 }
             }*/
            /* foreach(DirectoryInfo d in ds)
             {
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.BackgroundColor = ConsoleColor.White;
                 Console.WriteLine("Directory : " + d.Name);

             }
             foreach(FileInfo f in fs)
             {
                 Console.ForegroundColor = ConsoleColor.Blue;
                 Console.BackgroundColor = ConsoleColor.Green; 
                 Console.WriteLine("File : " + f.Name);
             }*/
            while (true)
            {

                ConsoleKeyInfo k = Console.ReadKey();
            if(k.Key == ConsoleKey.UpArrow)
                {
                    cur--;
                    if (cur == -1)
                    {
                        cur = fss.Length - 1;
                    }
                }
                if (k.Key == ConsoleKey.DownArrow)
                {
                    cur++;
                    if (cur == fss.Length)
                    {
                        cur = 0;
                    }
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    if (fss[cur].GetType() == typeof(DirectoryInfo))
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
                if(k.Key==ConsoleKey.Backspace || k.Key == ConsoleKey.Escape)
                {
                    directory = directory.Parent;
                    fss = directory.GetFileSystemInfos();
                }
                Console.Clear();
                File(cur, fss);
            }
        }
    }
}
