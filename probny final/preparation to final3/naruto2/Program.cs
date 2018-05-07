using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naruto2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn = Console.ReadKey();
            while(btn.Key != ConsoleKey.Q)
            {
                if (btn.Key == ConsoleKey.UpArrow)
                    Console.WriteLine("pressed Up arrow");
                if (btn.Key == ConsoleKey.DownArrow)
                    Console.WriteLine("pressed Down arrow");
                btn = Console.ReadKey();
            }
        }
    }
}
