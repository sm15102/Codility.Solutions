using Codility.Solutions.MaximumSliceProblem;
using Xunit;

namespace Codility.Solutions.Tests.MaximumSliceProblem
{
    public class MaxDoubleSliceSumTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = MaxDoubleSliceSum.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
