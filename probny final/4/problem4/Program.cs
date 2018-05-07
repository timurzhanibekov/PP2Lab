using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace problem4
{
    class Program
    {
        static int cnt = 1;
        static void Function()
        {
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 12; i++)
                {
                    if ((cnt == 1 && i >= 0 && i <= 3) || (cnt == 2 && i >= 4 && i <= 7) || (cnt == 3 && i >= 8 && i <= 11))
                    {
                        if (cnt == 1 && i >= 0 && i <= 3)
                            Console.ForegroundColor = ConsoleColor.Green;
                        if (cnt == 2 && i >= 4 && i <= 7)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        if (cnt == 3 && i >= 8 && i <= 11)
                            Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------");
                }
                if (cnt == 3)
                    cnt = 1;
                else
                    cnt++;
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread therad = new Thread(Function);
            therad.Start();
        }
    }
}
