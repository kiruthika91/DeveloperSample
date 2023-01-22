using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }

           [Fact]
        public void CanFormatSeparatorsForTwoElementsInInput()
        {
            Assert.Equal("a and b", Algorithms.FormatSeparators("a", "b"));
        }

               [Fact]
        public void CanFormatSeparatorsForOneElementInInput()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
        }

          [Fact]
        public void CanFormatSeparatorsForMoreThanThreeElementsInInput()
        {
            Assert.Equal("a, b, c and d", Algorithms.FormatSeparators("a", "b", "c", "d"));
        }
    }
}
