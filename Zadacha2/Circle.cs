using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha2
{
    internal class Circle
    {
        private double r;

        public Circle()
        {
            r = 1;
        }

        public Circle(double r)
        {
            if (r == 0)
            {
                Console.WriteLine("Радиусът не може да бъде равен на 0!");
                this.r = 1;
            }
            else
            {
                this.r = r;
            }
        }

        public double Area()
        {
            return Math.PI * r * r;
        }
    }
}
