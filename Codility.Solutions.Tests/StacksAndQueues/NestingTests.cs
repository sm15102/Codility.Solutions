using Codility.Solutions.StacksAndQueues;
using Xunit;

namespace Codility.Solutions.Tests.StacksAndQueues
{
    public class NestingTests
    {
        [Theory]
        [InlineData("(()(())())", 1)]
        [InlineData("())", 0)]

        public void Solution_OK(string S, int expected)
        {
            var result = Nesting.Solution(S);
            Assert.Equal(expected, result);
        }
    }
}
