using Codility.Solutions.Sorting;
using Xunit;

namespace Codility.Solutions.Tests.StacksAndQueues
{
    public class StoneWallTests
    {
        [Theory]
        [InlineData(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }, 7)]

        public void Solution_OK(int[] H, int expected)
        {
            var result = StoneWall.Solution(H);
            Assert.Equal(expected, result);
        }
    }
}
