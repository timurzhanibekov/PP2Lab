using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
          string name;
          int age;
          float gpa;
       public Student()
        {
            name = "kbtu";
            age = 18;
            gpa = 4;
        }
        public override string ToString()
        {
            return "name is - " + name + "age is - " + age + "gpa is - " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
