using Codility.Solutions.StacksAndQueues;
using Xunit;

namespace Codility.Solutions.Tests.StacksAndQueues
{
    public class FishTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }, 2)]

        public void Solution_OK(int[] A, int[] B, int expected)
        {
            var result = Fish.Solution(A, B);
            Assert.Equal(expected, result);
        }
    }
}
