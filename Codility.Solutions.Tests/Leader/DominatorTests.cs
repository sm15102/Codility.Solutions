using Codility.Solutions.Leader;
using Xunit;

namespace Codility.Solutions.Tests.Leader
{
    public class DominatorTests
    {
        [Theory]
        [InlineData(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }, new int[] { 0, 2, 4, 6, 7 })]

        public void Solution_OK(int[] A, int[] expected)
        {
            var result = Dominator.Solution(A);
            Assert.Contains<int>(result, expected);
        }
    }
}
