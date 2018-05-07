using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int index = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user\Desktop\tool for final");
            FileInfo[] files = directory.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                StreamReader v = new StreamReader(files[i].FullName);
                string s = v.ReadToEnd();
                for (int j = 0; j <s.Length; j++)
                {
                    for (int t = 1; t <= s[j]; t++)
                    {
                        if (s[j] % t == 0)
                            cnt++;
                    }
                    if (cnt == 2)
                        index = 1;
                    cnt = 0;
                }
                if (index == 1)
                {
                    Console.WriteLine(files[i].Name);
                }
            }
            Console.ReadKey();
        }
    }
}
