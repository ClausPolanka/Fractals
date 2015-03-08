using System;

namespace Fractals
{
    public class SquareSnowflake : KochSnowflake
    {
        private readonly int length;

        public SquareSnowflake(int length)
        {
            this.length = length;
        }

        public double Perimeter(int iteration)
        {
            return Math.Round(4 * length * Math.Pow(5 / 3.0, iteration));
        }
    }
}