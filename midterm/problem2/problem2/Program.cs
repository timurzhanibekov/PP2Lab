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
            string s = File.ReadAllText(@"C:\Users\user\Desktop\PP2Lab\mid.txt");
            string[] fs = s.Split(' ');
            string a;
            int min;
            for(int i = 0; i < fs.Length; i++)
            {
                for (int j = 1; j < fs.Length; j++)
                {
                    min = int.Parse(fs[0]);
                    if (min > int.Parse(fs[i]))
                    {
                        min = int.Parse(fs[i]);
                        
                    }
                }
            }
        }
    }
}
