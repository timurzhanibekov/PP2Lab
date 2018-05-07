using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace Complex
{
    [Serializable]
    class Program
    {
        static void F(complexclass result)
        {
            BinaryFormatter tr = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            tr.Serialize(fs, result);
            fs.Close();
        }
        static void F1()
        {
            BinaryFormatter tr = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            complexclass result = tr.Deserialize(fs) as complexclass;
            fs.Close();

            Console.WriteLine("deserialized elemen 1 is : " + result);
        }
        static void F2(complexclass result)
        {
            XmlSerializer tr = new XmlSerializer(typeof(complexclass));
            FileStream fs = new FileStream("ser.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            tr.Serialize(fs, result);
            fs.Close();
        }
        static void F3()
        {
            XmlSerializer tr = new XmlSerializer(typeof(complexclass));
            FileStream fs = new FileStream("ser.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            complexclass result = tr.Deserialize(fs) as complexclass;
            fs.Close();
            Console.WriteLine("deserialized element 2 is : " + result);
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int n = int.Parse(a.Split('/')[0]);
            int n_ = int.Parse(a.Split('/')[1]);
            int m = int.Parse(b.Split('/')[0]);
            int m_ = int.Parse(b.Split('/')[1]);
            complexclass y = new complexclass(n, n_);
            complexclass u = new complexclass(m, m_);
            complexclass result = y + u;
            Console.WriteLine(result);
            Console.ReadKey();
            F(result);
            F1();
            F2(result);
            F3(); 
            Console.ReadKey();
        }
    }
}
