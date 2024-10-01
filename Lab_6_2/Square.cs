using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    public class Square : IShape
    {
        public double A;

        public Square(double a)
        {
            A = a;
        }

        public double GetArea()
        {
            return A * A;
        }
    }
}
