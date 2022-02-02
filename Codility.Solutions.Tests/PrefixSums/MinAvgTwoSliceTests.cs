using Codility.Solutions.PrefixSums;
using Xunit;

namespace Codility.Solutions.Tests.PrefixSums
{
    public class MinAvgTwoSliceTests
    {
        [Theory]
        [InlineData(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = MinAvgTwoSlice.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
