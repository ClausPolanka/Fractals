using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fractals.Tests
{
    [TestFixture]
    public class FractalGeneratorTest
    {
        [TestCase(   243, 3,     1728)]
        [TestCase( 19683, 7,   442368)]
        [TestCase(531441, 7, 11943936)]
        [TestCase(531441, 9, 21233664)]
        public void cat_coder_acceptance_tests(int triangleLength, int iterations, int perimeter)
        {
            var result = Perimeter(triangleLength, iterations);
            Assert.AreEqual(perimeter, result, "perimeter");
        }

        public int Perimeter(int length, int iterations)
        {
            // Copied formula from http://en.wikipedia.org/wiki/Koch_snowflake
            return (int) Math.Round(3 * length * Math.Pow((double) 4 / 3, iterations));
        }
    }
}
