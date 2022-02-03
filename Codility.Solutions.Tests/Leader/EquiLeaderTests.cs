using Codility.Solutions.Leader;
using Xunit;

namespace Codility.Solutions.Tests.Leader
{
    public class EquiLeaderTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 4, 4, 4, 2 }, 2)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = EquiLeader.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
