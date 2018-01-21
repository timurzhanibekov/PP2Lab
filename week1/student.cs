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
        public override string ToString()
        {
            return firstname + " " + secondname + " " + old;
        }
        class Program
        {
            static void Main(string[] args)

            {
                Student s = new Student();
                s.firstname = "Erka";
                Student s2 = new Student();
                Console.WriteLine(s2);
                Console.WriteLine(s);
                Console.ReadKey();

            }
        }
    }
}