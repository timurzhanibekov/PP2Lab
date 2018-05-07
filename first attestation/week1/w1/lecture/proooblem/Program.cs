using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proooblem
{
    class Dog
    {
        public string name;
        public int age;
        public Dog()
        {
            name = "Max";
            age = 1;
        }
        public Dog(string n, int a)
        {
            name = n;
            age = a;
        }


        public override string ToString()
        {
            return name + " " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int a;
            n = Console.ReadLine();
            a = int.Parse(Console.ReadLine());

            Dog  d = new Dog(n, a);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
