using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    public class Circle : IShape
    {
        public double R;

        public Circle(double r)
        {
            R = r;
        }

        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
