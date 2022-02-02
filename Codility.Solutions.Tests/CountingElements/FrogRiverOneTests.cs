using Codility.Solutions.CountingElements;
using Xunit;

namespace Codility.Solutions.Tests.CountingElements
{
    public class FrogRiverOneTests
    {
        [Theory]
        [InlineData(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]

        public void Solution_OK(int X, int[] A, int expected)
        {
            var result = FrogRiverOne.Solution(X, A);
            Assert.Equal(expected, result);
        }
    }
}
