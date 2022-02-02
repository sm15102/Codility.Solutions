using Codility.Solutions.CountingElements;
using Xunit;

namespace Codility.Solutions.Tests.CountingElements
{
    public class PermCheckTests
    {
        [Theory]
        [InlineData(new int[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new int[] { 4, 1, 3 }, 0)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = PermCheck.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
