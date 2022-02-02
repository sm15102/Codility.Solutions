using Codility.Solutions.Arrays;
using Xunit;

namespace Codility.Solutions.Tests.Arrays
{
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4})]


        public void Solution_OK(int[] A, int K, int[] expected)
        {
            var result = CyclicRotation.Solution(A, K);
            Assert.Equal(expected, result);
        }
    }
}
