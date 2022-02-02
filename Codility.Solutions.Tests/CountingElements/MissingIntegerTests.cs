using Codility.Solutions.CountingElements;
using Xunit;

namespace Codility.Solutions.Tests.CountingElements
{
    public class MissingIntegerTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { -1, -3 }, 1)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = MissingInteger.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}