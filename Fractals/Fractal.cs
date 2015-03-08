using System;

namespace Fractals
{
    public class Fractal
    {
        private int length;

        public Fractal(int length)
        {
            this.length = length;
        }

        public double Perimeter(int iteration)
        {
            return Math.Round(3 * length * Math.Pow(4 / 3.0, iteration));
        }
    }
}