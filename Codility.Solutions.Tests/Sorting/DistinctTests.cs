using Codility.Solutions.Sorting;
using Xunit;

namespace Codility.Solutions.Tests.Sorting
{
    public class DistinctTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = Distinct.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
