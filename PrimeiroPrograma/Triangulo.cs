using System;

namespace PrimeiroPrograma
{
    internal class Triangulo
    {
        public double A, B, C;

        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
