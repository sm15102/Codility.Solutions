using Codility.Solutions.Iterations;
using Xunit;

namespace Codility.Solutions.Tests.Iterations
{
    public class BinaryGapTests
    {
        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(1041, 5)]

        public void Solution_OK(int N, int expected)
        {
            var result = BinaryGap.Solution(N);
            Assert.Equal(expected, result);
        }
    }
}
