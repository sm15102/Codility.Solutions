using Codility.Solutions.TimeComplexity;
using Xunit;

namespace Codility.Solutions.Tests.TimeComplexity
{
    public class FrogJmpTests
    {
        [Theory]
        [InlineData(10, 85, 30, 3)]

        public void FrogJmp_OK(int X, int Y, int D, int expected)
        {
            var result = FrogJmp.Solution(X, Y, D);
            Assert.Equal(expected, result);
        }
    }
}
