using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    [Serializable]
    public class complexclass
    {
        public int n;
        public int m;
        public complexclass() { }
        public complexclass(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
        public static int gcd(int n, int m)
        {
            if (n < m)
            {
                int x = n;
                n = m;
                m = x;
            }
            int d = n % m;
            if (d == 0)
                return m;
            else
                return gcd(d, m);
        } 
        public static complexclass operator+(complexclass w , complexclass q)
        {
            int lcm = w.m * q.m / gcd(w.m, q.m);
            int f = lcm / w.m * w.n + lcm / q.m * q.n;
            complexclass t = new complexclass(f, lcm);
            return t;
        }
        public override string ToString()
        {
            if (m == 1)
                return n + "";
            else if (n == m)
                return "1";
            else if (n % m == 0)
                return n / m+"";
            else
                return n + "/" + m;
        }

    }
}
