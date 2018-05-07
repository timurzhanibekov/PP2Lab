using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class rectangle
    {
        int a;
        int b;
        public rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int area(int x, int y)
        {
            return x * y;
        }
        public static int perimetr(int x, int y)
        {
            return 2*(x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("area is - " + rectangle.area(a, b));
            Console.WriteLine("perimetr is - " + rectangle.perimetr(a, b));
            Console.ReadKey();
          
        }
    }
}
