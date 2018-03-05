using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\user\Desktop\PP2Lab\proga.txt");
            string[] fs = s.Split(' ');
            int minn = 0;
            for (int i = 1; i<fs.Length; i++)
            {
                minn = int.Parse(fs[0]);
                if (int.Parse(fs[i]) < minn)
                {
                
                    minn = int.Parse(fs[i]);
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\user\Desktop\PP2Lab\result.txt");
            sw.WriteLine(minn);
            sw.Close();
            Console.ReadKey();

        }
    }
}
