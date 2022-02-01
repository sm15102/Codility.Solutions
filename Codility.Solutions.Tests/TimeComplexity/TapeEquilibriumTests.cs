using Codility.Solutions.TimeComplexity;
using Xunit;

namespace Codility.Solutions.Tests.TimeComplexity
{
    public class TapeEquilibriumTests
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4, 3 }, 1)]

        public void FrogJmp_OK(int[] A, int expected)
        {
            var result = TapeEquilibrium.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
