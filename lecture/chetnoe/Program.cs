﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chetnoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\user\Desktop\PP2Lab\proga.txt");
            string[] fs = s.Split(' ');
            string ls="";
            for (int i = 1; i<fs.Length; i++)
            {
                if (i % 2 == 0 && int.Parse(fs[i]) % 2 == 0)
                {
                    ls += fs[i];
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\user\Desktop\PP2Lab\result.txt");
            sw.WriteLine(ls);
            sw.Close();
        }
    }
}
