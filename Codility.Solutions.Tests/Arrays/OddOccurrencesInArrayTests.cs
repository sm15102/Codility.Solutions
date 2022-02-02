using Codility.Solutions.Arrays;
using Xunit;

namespace Codility.Solutions.Tests.Arrays
{
    public class OddOccurrencesInArrayTests
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = OddOccurrencesInArray.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
