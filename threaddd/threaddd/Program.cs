using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threaddd
{
    class Program
    {
        public static void Write()
        {
            int a = 0;
            while (true)
            {
                Console.WriteLine(a);
                Thread.Sleep(500);
                a++;
                
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(Write);
            t.Start();
        }
    }
}
