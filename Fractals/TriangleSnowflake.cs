using System;

namespace Fractals
{
    public class TriangleSnowflake : KochSnowflake
    {
        private int length;

        public TriangleSnowflake(int length)
        {
            this.length = length;
        }

        public double Perimeter(int iteration)
        {
            return Math.Round(3 * length * Math.Pow(4 / 3.0, iteration));
        }
    }
}