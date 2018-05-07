using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        { 
            string line = Console.ReadLine();//6 1 2 3 4 5
            string[] arr = line.Split(' ');//6.1.2.3.4.5
            for (int i = 0; i < arr.Length; i++)//1 2 3 4 5 6 7
            {
                int k = 0;

                for (int j = 2; j < int.Parse(arr[i]); j++)
                {

                    if (int.Parse(arr[i]) % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine(arr[i]);
                    
                }
                
            }
                
               Console.ReadKey();     

             
                   
        }
    }
}