using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Models;

namespace MyProject.Tests
{
    [TestFixture]
    public class StringManipulationTests
    {
        [Test]
        public void Substitute_ReplacesSubstring()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dog.";
            string search = "quick";
            string replace = "slow";
            string expected = "The slow brown fox jumps over the lazy dog.";
            string actual;

            // Act
            actual = StringManipulation.Substitute(input, search, replace);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
