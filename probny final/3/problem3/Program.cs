using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user\Desktop\PP2Lab\files");
            FileInfo[] file = directory.GetFiles();
            for (int i = 0; i < file.Length; i++)
            {
                StreamReader sr = new StreamReader(file[i].FullName);
                string a = sr.ReadToEnd();
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == 'K' && a[j+1] == 'B' && a[j+2] == 'T' && a[j+3] == 'U')
                        index = 1;
                }
                if(index==1)
                    Console.WriteLine(file[i].Name);
                Console.ReadKey();
                index = 0;
            }
        }
    }
}
