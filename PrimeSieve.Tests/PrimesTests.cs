using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PrimeSieve.Tests
{
    [TestClass]
    public class PrimesTests
    {
        [TestMethod]
        public void Generate_WithMaxValue10_ReturnsCorrectPrimes()
        {
            var expected = new List<int> { 2, 3, 5, 7 };
            var actual = PrimeSieve.Primes.Generate(10);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Generate_WithMaxValue1_ReturnsEmptyList()
        {
            var result = PrimeSieve.Primes.Generate(1);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Generate_WithMaxValue2_ReturnsTwo()
        {
            var expected = new List<int> { 2 };
            var actual = PrimeSieve.Primes.Generate(2);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
