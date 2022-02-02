using Codility.Solutions.TimeComplexity;
using Xunit;

namespace Codility.Solutions.Tests.TimeComplexity
{
    public class PermMissingElemTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = PermMissingElem.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
