using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace map
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\user\Desktop\PP2Lab\proga.txt");
            string[] fs = s.Split(' ');
            int n;
            string[] ls;
            for(int i = 0; i<fs.Length; i++)
            {
                n = int.Parse(fs[i]);
                for(int j = i; j<fs.Length; j++)
                {
                    if (n < int.Parse(fs[i]))
                    {
                        ls = fs[i]; 
                    }
                }
                
            }
            int m;
            Console.WriteLine() = Console.ReadLine([int.Parse(m)])
            
        }
    }
}
