using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\user\Desktop\PP2Lab\proga.txt");
            string[] a = s.Split(' ');
            int maxx = -8458;
            int minn = 56556;
            foreach(string m in a)
            {
                maxx = Math.Max(maxx, int.Parse(m));
                minn = Math.Min(minn, int.Parse(m));
            }
            Console.WriteLine("the max number is - " + maxx);
            Console.WriteLine("the min number is - " + minn);
            Console.ReadKey();
        }
    }
}
