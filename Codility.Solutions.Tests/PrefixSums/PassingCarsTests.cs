using Codility.Solutions.PrefixSums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Solutions.Tests.PrefixSums
{
    public class PassingCarsTests
    {
        [Theory]
        [InlineData(new int[] { 0,1,0,1,1}, 5)]

        public void Solution_OK(int[] A, int expected)
        {
            var result = PassingCars.Solution(A);
            Assert.Equal(expected, result);
        }
    }
}
