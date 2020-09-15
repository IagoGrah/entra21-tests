using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class yUmTests
    {
        [Theory]
        [InlineData(new double[2]{8, 5.43}, new double[2]{12, 99}, new double[2]{-4, -93.57})]
        [InlineData(new double[3]{76, 0, -23}, new double[3]{44, 0, -11}, new double[3]{32, 0, -12})]
        public void should_return_C_as_sums_of_A_and_B(double[] A, double[] B, double[] expected)
        {
            var arrays = new Arrays();

            var result = arrays.yUm(A, B);

            Assert.Equal(result, expected);
        }
    }
    
    public class yDoisTests
    {
        [Theory]
        [InlineData(new int[4]{1, 3, 2, 4}, new int[4]{4, 2, 3, 1})]
        [InlineData(new int[2]{-43, 0}, new int[2]{0, -43})]
        [InlineData(new int[3]{0, 5, 0}, new int[3]{0, 5, 0})]
        public void should_return_reversed(int[] input, int[] expected)
        {
            var arrays = new Arrays();

            var result = arrays.yDois(input.ToList());

            Assert.Equal(expected, result);
        }
    }
}
