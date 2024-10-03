using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sandbox.ConsoleApp;

namespace Sandbox.ConsoleApp.Test
{
    [TestFixture]   
    public class ArrayQuizProblemsTests
    {
        private ArrayQuizProblems _arrayQuizProblems;

        [SetUp]
        public void Setup()
        {
            _arrayQuizProblems = new ArrayQuizProblems();
        }

        [Test]
        public void FindMaxDifference_ValidInput_ReturnsCorrectDifference()
        {
            // Arrange
            int[] numbers = { 2, 3, 10, 6, 4, 8, 1 };

            // Act
            int result = _arrayQuizProblems.FindMaxDifference(numbers);

            // Assert
            Assert.AreEqual(8, result);  // Expected difference is 8 (10 - 2)
        }

        [Test]
        public void FindMaxDifference_AllElementsSame_ReturnsZero()
        {
            // Arrange
            int[] numbers = { 5, 5, 5, 5 };

            // Act
            int result = _arrayQuizProblems.FindMaxDifference(numbers);

            // Assert
            Assert.AreEqual(0, result);  // Expected difference is 0
        }

        [Test]
        public void FindMaxDifference_SingleElementArray_ThrowsException()
        {
            // Arrange
            int[] numbers = { 10 };

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => _arrayQuizProblems.FindMaxDifference(numbers));
        }

        [Test]
        public void IsSubsequence_ValidSubsequence_ReturnsTrue()
        {
            // Arrange
            string first = "abc";
            string second = "xabbcy";

            // Act
            bool result = _arrayQuizProblems.IsSubsequence(first, second);

            // Assert
            Assert.IsTrue(result);  // Expected true because 'abc' is a subsequence of 'xabbcy'
        }

        [Test]
        public void IsSubsequence_InvalidSubsequence_ReturnsFalse()
        {
            // Arrange
            string first = "abc";
            string second = "xacby";

            // Act
            bool result = _arrayQuizProblems.IsSubsequence(first, second);

            // Assert
            Assert.IsFalse(result);  // Expected false because the sequence 'abc' is not found in 'xacby'
        }

        [Test]
        public void IsSubsequence_EmptyFirstString_ReturnsTrue()
        {
            // Arrange
            string first = "";
            string second = "anything";

            // Act
            bool result = _arrayQuizProblems.IsSubsequence(first, second);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsSubsequence_EmptySecondString_ReturnsFalse()
        {
            // Arrange
            string first = "abc";
            string second = "";

            // Act
            bool result = _arrayQuizProblems.IsSubsequence(first, second);

            // Assert
            Assert.IsFalse(result);  // Expected false because a non-empty string cannot be a subsequence of an empty string
        }


    }
}
