using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                string b = a[i];
                for (int j = 0; j < b.Length/2; j++)
                {
                    if (b[j] == b[b.Length - 1 - j])
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine(a.Length);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
