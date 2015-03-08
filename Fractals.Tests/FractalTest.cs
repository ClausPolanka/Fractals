using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fractals.Tests
{
    [TestFixture]
    public class FractalTest
    {
        [TestCase(9, 1, 36.0)]
        [TestCase(243, 3, 1728.0)]
        [TestCase(19683, 7, 442368.0)]
        [TestCase(531441, 7, 11943936.0)]
        [TestCase(531441, 9, 21233664.0)]
        public void Perimeter_after_given_number_of_iterations(
            int length, 
            int iteration,
            double expected)
        {
            var sut = new Fractal(length);
            var perimeter = sut.Perimeter(iteration);
            Assert.That(perimeter, Is.EqualTo(expected), 
                string.Format("perimeter of triangle with l={0}, after {1} iteration(s).", 
                length, 
                iteration));
        }
    }
}
