using Codility.Solutions.PrefixSums;
using Xunit;

namespace Codility.Solutions.Tests.PrefixSums
{
    public class CountDivTests
    {
        [Theory]
        [InlineData(6, 11, 2, 3)]

        public void Solution_OK(int A, int B, int K, int expected)
        {
            var result = CountDiv.Solution(A, B, K);
            Assert.Equal(expected, result);
        }
    }
}
