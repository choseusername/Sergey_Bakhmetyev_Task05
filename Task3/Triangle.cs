using System;

namespace Task3
{
    class Triangle
    {
        public readonly double A, B, C;
        public double GetPerimeter() => A + B + C;

        public double GetArea()
        {
            // semiperimeter
            double p = GetPerimeter() / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public Triangle(double a, double b, double c)
        {
            if ((a <= b + c) && (b <= a + c) && (c <= a + b))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("Triangle with specified sides does not exist");
            }
        }

        public override string ToString()
        {
            return string.Format("Треугольник со сторонами: {0}, {1}, {2}.\n" +
                "Периметр: {3}\nПлощадь: {4}",
                A, B, C, GetPerimeter(), GetArea());
        }
    }
}
