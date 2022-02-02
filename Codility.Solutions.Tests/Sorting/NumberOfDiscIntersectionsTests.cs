using Codility.Solutions.Sorting;
using Xunit;

namespace Codility.Solutions.Tests.Sorting
{
    public class NumberOfDiscIntersectionsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = NumberOfDiscIntersections.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
