
namespace Sandbox.ConsoleApp.Test
{
    [TestFixture]
    public class RankingTests
    {
        Ranking ranking;

        [SetUp]
        public void SetUp()
        {
            ranking = new Ranking();
        }

        [Test]
        public void RankElementsByCriteria_BasicTest_ReturnsRankedElements()
        {
            // Arrange
            var listOfArrays = new List<char[]>
            {
                new char[] { 'a', 'b', 'c' },
                new char[] { 'a', 'b', 'a' },
                new char[] { 'c', 'b', 'b' }
            };
            var inputArray = new char[] { 'a' }; // 'a' should be excluded

            // Act
            var result = ranking.RankElementsByCriteria(listOfArrays, inputArray).ToList();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(('b', 4), result[0]); // 'b' appears 4 times
            Assert.AreEqual(('c', 2), result[1]); // 'c' appears 2 times
        }

        [Test]
        public void RankElementsByCriteria_InputArrayExcludesAll_ReturnsEmpty()
        {
            // Arrange
            var listOfArrays = new List<char[]>
            {
                new char[] { 'x', 'y', 'z' },
                new char[] { 'x', 'y', 'x' }
            };
            var inputArray = new char[] { 'x', 'y', 'z' }; // All characters excluded

            // Act
            var result = ranking.RankElementsByCriteria(listOfArrays, inputArray);

            // Assert
            Assert.IsEmpty(result); // Expecting no results
        }

        [Test]
        public void RankElementsByCriteria_EmptyList_ReturnsEmpty()
        {
            // Arrange
            var listOfArrays = new List<char[]>();
            var inputArray = new char[] { 'a', 'b' };

            // Act
            var result = ranking.RankElementsByCriteria(listOfArrays, inputArray);

            // Assert
            Assert.IsEmpty(result); // No elements to rank
        }

        [Test]
        public void RankElementsByCriteria_NullInputList_ThrowsArgumentNullException()
        {
            // Arrange
            List<char[]> listOfArrays = null;
            var inputArray = new char[] { 'a', 'b' };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ranking.RankElementsByCriteria(listOfArrays, inputArray));
        }

        [Test]
        public void RankElementsByCriteria_NullInputArray_ThrowsArgumentNullException()
        {
            // Arrange
            var listOfArrays = new List<char[]>
            {
                new char[] { 'a', 'b', 'c' },
                new char[] { 'a', 'b', 'a' },
            };
            char[] inputArray = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => ranking.RankElementsByCriteria(listOfArrays, inputArray));
        }
    }
}

