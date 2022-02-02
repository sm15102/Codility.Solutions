using Codility.Solutions.CountingElements;
using Xunit;

namespace Codility.Solutions.Tests.CountingElements
{
    public class MaxCountersTests
    {
        [Theory]
        [InlineData(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]

        public void Solution_OK(int N, int[] A, int[] expected)
        {
            var result = MaxCounters.Solution(N, A);
            Assert.Equal(expected, result);
        }
    }
}
