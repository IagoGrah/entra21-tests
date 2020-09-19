using Xunit;
using System.Linq;

namespace entra21_tests
{
    public class xUmTests
    {
        [Fact]
        public void should_return_1_to_10_string()
        {
            var exercises = new Exercicios();
            
            var expected = "1 2 3 4 5 6 7 8 9 10";
            var result = exercises.xUmA();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void should_return_10_to_1_string()
        {
            var exercises = new Exercicios();
            
            var expected = "10 9 8 7 6 5 4 3 2 1";
            var result = exercises.xUmB();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void should_return_1_to_10_only_odds_string()
        {
            var exercises = new Exercicios();
            
            var expected = "1 3 5 7 9";
            var result = exercises.xUmC();

            Assert.Equal(expected, result);
        }
    }

    public class xDoisTests
    {
        [Fact]
        public void should_return_5050()
        {
            var exercises = new Exercicios();
            
            var result = exercises.xDois();

            Assert.Equal(5050, result);
        }
    }

    public class xTresTests
    {
        [Fact]
        public void should_return_odd_numbers_from_1_to_200()
        {
            var exercises = new Exercicios();

            var expected = "1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,101,103,105,107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199";
            var result = exercises.xTres();

            Assert.Equal(expected, result);
        }
    }
    
    public class xQuatroTests
    {
        [Theory]
        [InlineData(new int[2]{17, 15}, 16)]
        [InlineData(new int[4]{13, 14, 15, 16}, 14.5)]
        [InlineData(new int[0], 0)]

        public void should_return_average(int[] ages, double expected)
        {
            var exercises = new Exercicios();

            double result = exercises.xQuatro(ages.ToList());

            Assert.Equal(expected, result);
        }
    }

    public class xCincoTests
    {
        [Theory]
        [InlineData(new double[5]{45, 23, 14, 35, 18}, 60)]
        [InlineData(new double[8]{45, 23, 14, 35, 18, 89, 25, 32}, 62.5)]
        public void should_return_percentage_of_ages_between_18_and_35(double[] ages, double expected)
        {
            var exercises = new Exercicios();

            double result = exercises.xCinco(ages.ToList());

            Assert.Equal(expected, result);
        }
    }

    public class xSeteTests
    {
        [Theory]
        [InlineData(4, 23, 2.50, 4197.5)]
        public void should_return_4197_dot_5(double cigDia, double anos, double preco, double expected)
        {
            var exercises = new Exercicios();

            var result = exercises.xSete(cigDia, anos, preco);

            Assert.Equal(expected, result);
        }
    }
    
    public class xOitoTests
    {
        [Theory]
        [InlineData(60, 3, true)]
        [InlineData(54, 8, false)]
        [InlineData(-54, -9, true)]
        public void should_return_true_when_multiples(double a, double b, bool expected)
        {
            var exercises = new Exercicios();

            bool result = exercises.xOito(a, b);
            
            Assert.Equal(expected, result);
        }
    }

    public class xNoveTests
    {
        [Theory]
        [InlineData(34.2, 12.76543, 67, false)]
        [InlineData(9999, 0.0005, 15.123521345, true)]
        public void should_return_true_when_x_bigger_than_sum_of_y_and_z(double x, double y, double z, bool expected)
        {
            var exercises = new Exercicios();

            bool result = exercises.xNove(x, y, z);

            Assert.Equal(expected, result);
        }
    }

    public class xDezTests
    {
        [Theory]
        [InlineData(15, -56, "15>-56")]
        [InlineData(-45, -32, "-32>-45")]
        [InlineData(0, 0, "0=0")]
        public void should_say_which_is_bigger_or_if_equals(double a, double b, string expected)
        {
            var exercises = new Exercicios();

            var result = exercises.xDez(a, b);

            Assert.Equal(expected, result);
        }
    }

    public class xOnzeTests
    {
        [Theory]
        [InlineData(18, 6, 3)]
        [InlineData(-15, 5, -3)]
        [InlineData(999, 0, 0)]
        public void should_return_result_of_division(double a, double b, double expected)
        {
            var exercises = new Exercicios();

            var result = exercises.xOnze(a, b);

            Assert.Equal(expected, result);
        }
    }

    public class xDozeTests
    {
        [Theory]
        [InlineData(new int[3]{5, 0, 2}, 2, 5)]
        [InlineData(new int[7]{56, 45, 23, 22, 33, 12, 10}, 100, 101)]
        public void should_return_sum_of_evens_and_sum_of_odds(int[] numbers, int sumEvens, int sumOdds)
        {
            var exercises = new Exercicios();

            var result = exercises.xDoze(numbers);
            (int, int) expected = (sumEvens, sumOdds);

            Assert.Equal(expected, result);
        }
    }

    public class xTrezeTests
    {
        [Theory]
        [InlineData(new double[6]{65.2, 89.1, 58, 167, -54, 0}, 167)]
        [InlineData(new double[3]{-15.2, -676.3, -12}, -12)]
        public void should_return_167(double[] input, double expected)
        {
            var exercises = new Exercicios();

            double result = exercises.xTreze(input.ToList());

            Assert.Equal(expected, result);
        }
    }

    public class xQuatorzeTests
    {
        [Theory]
        [InlineData(new double[3]{5, 4, 9}, "4 < 5 < 9")]
        [InlineData(new double[6]{0.4, 28, -43, 0, 2, 999}, "-43 < 0 < 0,4 < 2 < 28 < 999")]
        [InlineData(new double[2]{0, 0}, "0 < 0")]
        public void should_return_crescent_string(double[] numbers, string expected)
        {
            var exercises = new Exercicios();

            string result = exercises.xQuatorze(numbers.ToList());

            Assert.Equal(expected, result);
        }
    }

    public class xQuinzeTests
    {
        [Theory]
        [InlineData(new double[3]{15, 21, 33}, 3, 1)]
        [InlineData(new double[7]{56, 45, 23, 22, 33, 12, 10}, 3, 2)]
        public void should_return_how_many_multiples_of_3_and_of_5(double[] numbers, int multi3, int multi5)
        {
            var exercises = new Exercicios();

            var result = exercises.xQuinze(numbers.ToList());
            (int, int) expected = (multi3, multi5);

            Assert.Equal(expected, result);
        }
    }
    
    public class xDezesseisTests
    {
        [Theory]
        [InlineData(450, 450)]
        [InlineData(1000, 800)]
        [InlineData(1500, 1125)]
        [InlineData(3000, 2100)]
        public void should_return_liquid_salary(double salary, double expected)
        {
            var exercises = new Exercicios();

            var result = exercises.xDezesseis(salary);

            Assert.Equal(expected, result);
        }
    }

    public class xDezesseteTests
    {
        [Theory]
        [InlineData(6, new double[5]{1, 3, 5, 7, 9}, new double[5]{6, 18, 30, 42, 54})]
        [InlineData(3.5, new double[3]{1, 2, 3}, new double[3]{3.5, 7, 10.5})]
        [InlineData(0, new double[4]{0.65, -43, 999, 0}, new double[4]{0, 0, 0, 0})]
        public void should_return_x_multiplied_by_numbers_of_array(double x, double[] multiples, double[] expected)
        {
            var exercises = new Exercicios();

            var result = exercises.xDezessete(x, multiples.ToList());

            Assert.Equal(expected, result);
        }
    }

    public class xDezoitoTests
    {
        [Theory]
        [InlineData(31, 33.1)]
        [InlineData(24, 24)]
        [InlineData(0, 0)]
        public void should_return_33dot1(int macas, double expected)
        {
            var exercises = new Exercicios();

            double result = exercises.xDezoito(macas);

            Assert.Equal(expected, result);
        }
    }
}