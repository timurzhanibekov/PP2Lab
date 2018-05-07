using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectanglecircle
{
    class Class1
    {
        public int width;
        public int length;
        public int area;

        public Class1()
        {
            width = 5;
            length = 10;
        }
        public Class1(int w, int l)
        {
            width = w;
            length = l;
        }
        public void findarea()
        {
            area = width * length;
        }
        public override string ToString()
        {
            return area + " ";
        }
    }
}
