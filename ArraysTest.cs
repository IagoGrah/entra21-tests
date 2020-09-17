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

    public class yTresTests
    {
        [Theory]
        [InlineData(new double[7]{1,2,3,4,5,6,7}, 4, true)]
        [InlineData(new double[7]{1,2,3,4.001,5,6,7}, 3.99, false)]
        public void should_return_true_when_array_contains_num(double[] arr, double num, bool expected)
        {
            var arrays = new Arrays();

            var result = arrays.yTres(arr, num);

            Assert.Equal(expected, result);
        }
    }

    public class yQuatroTests
    {
        [Theory]
        [InlineData(new double[4]{3.2,-2,1,0}, new double[4]{3.2,-2,1,0}, true)]
        [InlineData(new double[5]{0,0,0,0,0}, new double[5]{0,0,0,1,0}, false)]
        [InlineData(new double[2]{1,2}, new double[3]{1,2,3}, false)]
        [InlineData(new double[1]{-55}, new double[1]{-55}, true)]
        [InlineData(new double[0]{}, new double[0]{}, true)]
        public void should_return_true_when_arrays_are_identical(double[] arrA, double[] arrB, bool expected)
        {
            var arrays = new Arrays();

            var result = arrays.yQuatro(arrA, arrB);

            Assert.Equal(expected, result);
        }
    }

    public class yCincoTests
    {
        [Theory]
        [InlineData(new double[5]{1,2,3,4,5}, 3, 2, 1, 2)]
        [InlineData(new double[3]{5, 0, -5}, 0, 1, 1, 1)]
        [InlineData(new double[2]{5.5, 3.5}, 4.5, 1, 0, 1)]
        public void should_return_avg_and_how_many_below_on_and_above_avg(double[] arr, double avg, int below, int on, int above)
        {
            var arrays = new Arrays();

            var result = arrays.yCinco(arr);
            (double avg, int below, int on, int above) expected = (avg, below, on, above);

            Assert.Equal(expected, result);
        }
    }

    public class ySeisTests
    {
        [Theory]
        [InlineData(new double[2]{1,7}, new double[2]{9,4}, new double[2]{10, 11})]
        [InlineData(new double[3]{-56,0,12}, new double[3]{0.56,21,15}, new double[3]{-35,12.56,15})]
        public void should_return_crescent_array_as_sums_of_A_crescent_and_B_decrescent(double[] A, double[] B, double[] expected)
        {
            var arrays = new Arrays();

            var result = arrays.ySeis(A, B);

            Assert.Equal(expected, result);
        }
    }
}
