using Codility.Solutions.Sorting;
using Xunit;

namespace Codility.Solutions.Tests.Sorting
{
    public class MaxProductOfThreeTests
    {
        [Theory]
        [InlineData(new int[] { -3, 1, 2, -2, 5, 6 }, 60)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = MaxProductOfThree.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
