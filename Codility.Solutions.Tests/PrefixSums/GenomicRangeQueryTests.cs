using Codility.Solutions.PrefixSums;
using Xunit;

namespace Codility.Solutions.Tests.PrefixSums
{
    public class GenomicRangeQueryTests
    {
        [Theory]
        [InlineData("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 })]

        public void Solution_OK(string S, int[] P, int[] Q, int[] expected)
        {
            var result = GenomicRangeQuery.Solution(S, P, Q);
            Assert.Equal(expected, result);
        }
    }
}
