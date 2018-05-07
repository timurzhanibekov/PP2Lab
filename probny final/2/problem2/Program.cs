using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = -999999;
            int max2 = -99998;
            int index=0;
            StreamReader st = new StreamReader(@"C:\Users\user\Desktop\PP2Lab\probny final\max2.txt");
            string s = st.ReadToEnd();
            string [] a = s.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                if (int.Parse(a[i]) > max)
                {
                    max = int.Parse(a[i]);
                    index = i;
                    
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (int.Parse(a[j]) > max2 && j != index)
                {
                    max2 = int.Parse(a[j]);
                }
            }
            StreamWriter tm = new StreamWriter(@"C:\Users\user\Desktop\PP2Lab\probny final\answer.txt");
            tm.WriteLine(max2);
            tm.Close();
        }
    }
}
