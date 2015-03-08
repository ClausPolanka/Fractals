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
        [TestCase(9, 1, 36)]
        public void Perimeter_after_given_number_of_iterations(
            int length, 
            int iteration,
            int expected)
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
