using Codility.Solutions.MaximumSliceProblem;
using Xunit;

namespace Codility.Solutions.Tests.MaximumSliceProblem
{
    public class MaxProfitTests
    {
        [Theory]
        [InlineData(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = MaxProfit.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
