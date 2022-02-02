using Codility.Solutions.Sorting;
using Xunit;

namespace Codility.Solutions.Tests.Sorting
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new int[] { 10, 50, 5, 1 }, 0)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = Triangle.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
