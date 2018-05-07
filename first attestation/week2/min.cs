using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\user\Desktop\PP2Lab\proga.txt");
            string[] m = s.Split(' ');
            int minn = 546465;
            for(int i = 0; i < m.Length; i++)
            {
                bool t = true;
                for (int j = 2; j * j <= int.Parse(m[i]); j++)
                {
                    if (int.Parse(m[i]) % j == 0)
                    {
                        t = false;
                        break;
                    }

                }
                if (t == true && int.Parse(m[i]) != 1)
                {
                    minn = Math.Min(minn, int.Parse(m[i]));
                }

            }
            Console.WriteLine(minn);
            Console.ReadKey();
        }
    }
}
