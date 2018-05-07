using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Student
    {
        public string firstname;
        public string secondname;
        public int old;
        public Student()
        {
            firstname = "Ernur";
            secondname = "Kydyrbaev";
            old = 18;
        }
        public Student(string s, string h, int a)
        {
            firstname = s;
            secondname = h;
            old = a;
        }
        public override string ToString()
        {
            return firstname + " " + secondname + " " + old;
        }
        class Program
        {
            static void Main(string[] args)

            {
                string s, h;
                int a;
                s = Console.ReadLine();
                h = Console.ReadLine();
                a = Convert.ToInt32(Console.ReadLine());
                Student s = new Student(s, h, a);
                Console.WriteLine(s);
            }
        }
    }
}