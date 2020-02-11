using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Parallelepiped
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;

        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double V 
        {
            get
            {
                return A * B * C;
            }
        }


        public double S
        {
            get
            {
                return 2*A*B+2*A*C+2*B*C;
            }
        }
    }
}
