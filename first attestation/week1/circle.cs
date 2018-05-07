using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class circle
    {
        int r;
        public circle(int r)
        {
            this.r = r;
        }
        public static int diametr(int r)
        {
            return 2 * r;
        }
        public static double area(int r)
        {
            return Math.PI * r * r;
        }
        public static double circumference(int r)
        {
            return 2 * Math.PI * r; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("diametr is - " + circle.diametr(r));
            Console.WriteLine("area is - " + circle.area(r));
            Console.WriteLine("circumference is - " + circle.circumference(r));
            Console.ReadKey();
        }
    }
}
