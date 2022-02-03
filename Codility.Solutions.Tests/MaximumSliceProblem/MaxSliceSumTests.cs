using Codility.Solutions.MaximumSliceProblem;
using Xunit;

namespace Codility.Solutions.Tests.MaximumSliceProblem
{
    public class MaxSliceSumTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, -6, 4, 0 }, 5)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = MaxSliceSum.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
