using Xunit;
using Domain;

namespace Tests
{
    public class zUmTests
    {
        [Theory]
        [InlineData(new double[]{5,4,3,2}, new double[]{6,7,8,9})]
        public void should_return_switched_arrays(double[] inputA, double[] inputB)
        {
            var arrays2 = new Arrays2();
            var originalA = new double[inputA.Length];
            var originalB = new double[inputB.Length];
            inputA.CopyTo(originalA, 0);
            inputB.CopyTo(originalB, 0);

            var result = arrays2.zUm(inputA, inputB);

            Assert.Equal(originalB, result.A);
            Assert.Equal(originalA, result.B);
        }
    }

    public class zDoisTests
    {
        [Theory]
        [InlineData(new double[]{1, -2, 3.4, 5}, false)]
        [InlineData(new double[]{0, 0, 0, 0}, true)]
        [InlineData(new double[]{0, 1, 2.45, 0}, true)]
        [InlineData(new double[]{0, 0.001, 0.002}, false)]
        public void should_return_true_if_contains_repeated_numbers(double[] input, bool expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zDois(input);

            Assert.Equal(expected, result);
        }
    }

    public class zTresTests
    {
        [Theory]
        [InlineData(new char[]{'f', 'm', 'f'}, new char[]{'y', 'n', 'n'}, 50)]
        [InlineData(new char[]{'f', 'f', 'f'}, new char[]{'n', 'n', 'n'}, 0)]
        [InlineData(new char[]{'f', 'f'}, new char[]{'y', 'y'}, 100)]
        public void should_return_percentage_of_women_who_said_yes(char[] genders, char[] answers, double expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zTres(genders, answers);

            Assert.Equal(expected, result);
        }
    }

    public class zQuatroTests
    {
        [Theory]
        [InlineData(new int[]{1,2,3,4,5,6}, 9)]
        [InlineData(new int[]{0}, 0)]
        [InlineData(new int[]{11, 0, -43, -12}, -32)]
        public void should_return_sum_of_odd_numbers(int[] input, int expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zQuatro(input);

            Assert.Equal(expected, result);
        }
    }

    public class zCincoTests
    {
        [Theory]
        [InlineData(new double[]{1, -2, -3, -0.440, 67.3}, 2)]
        [InlineData(new double[]{0, 0, 0, -0}, 0)]
        [InlineData(new double[]{0.00001, 987, -90192}, 2)]
        public void should_return_how_many_positive_numbers(double[] input, int expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zCinco(input);

            Assert.Equal(expected, result);
        }
    }

    public class zSeisTests
    {
        [Fact]
        public void should_throw_exception_if_negative_numbers()
        {
            var arrays2 = new Arrays2();
            var input = new double[]{-2, 0, 1, 2};

            Assert.Throws<System.ArgumentException>(() => arrays2.zSeis(input));            
        }
        
        [Theory]
        [InlineData(new double[]{1,2,3,4,5,3}, 4)]
        [InlineData(new double[]{0,0,1}, 2)]
        [InlineData(new double[]{999.34,0,1}, 0)]
        public void should_return_index_of_biggest_number(double[] input, int expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zSeis(input);

            Assert.Equal(expected, result);
        }
    }

    public class zSeteTests
    {
        [Theory]
        [InlineData(new double[]{0,1,2,3,4}, 5)]
        [InlineData(new double[]{1,2,3,4}, 0)]
        [InlineData(new double[]{0,3,2,1,4}, 3)]
        public void should_return(double[] input, int expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zSete(input);

            Assert.Equal(expected, result);
        }
    }

    public class zOitoTests
    {
        [Theory]
        [InlineData(new char[]{'a', 'e', 'i', 'o', 'u'}, 5)]
        [InlineData(new char[]{'f', 'g', 'h', 'j', 'k'}, 0)]
        [InlineData(new char[]{'i', 'e'}, 2)]
        [InlineData(new char[]{'t', 'a', 'e', 'o', 'p'}, 3)]
        public void should_return_how_many_vowels(char[] input, int expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zOito(input);

            Assert.Equal(expected, result);
        }
    }

    public class zNoveTests
    {
        [Theory]
        [InlineData(new char[]{'o', 'u', 'l', 'p', 'a'}, "ola")]
        [InlineData(new char[]{'f', 'g', 'h', 'j', 'k'}, "fhk")]
        [InlineData(new char[]{'i', 'e'}, "i")]
        [InlineData(new char[]{'t'}, "t")]
        public void should_return_string_of_chars_on_even_index(char[] input, string expected)
        {
            var arrays2 = new Arrays2();

            var result = arrays2.zNove(input);

            Assert.Equal(expected, result);
        }
    }
}
