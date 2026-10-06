using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha2
{
    internal class Rectangle
    {
        private double a;
        private double b;

        public Rectangle()
        {
            a = 1;
            b = 1;
        }

        public Rectangle(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Страните не могат да бъдат равни на 0!");
                this.a = 1;
                this.b = 1;
            }
            else
            {
                this.a = a;
                this.b = b;
            }
        }

        public double Area()
        {
            return a * b;
        }
    }
}
