using System.Collections.Generic;
using Xunit;

namespace entra21_tests
{
    public class xQuatroTests
    {
        [Fact]
        public void should_return_16_when_given_17_and_15()
        {
            var exercises = new Exercicios();
            var input = new List<int>(){17, 15};

            double result = exercises.xQuatro(input);

            Assert.Equal(16, result);
        }
        
        [Fact]
        public void should_return_14_dot_5_when_given_13_14_15_16()
        {
            var exercises = new Exercicios();
            var input = new List<int>(){13, 14, 15, 16};

            double result = exercises.xQuatro(input);

            Assert.Equal(14.5, result);
        }

        [Fact]
        public void should_return_0_when_given_empty_list()
        {
            var exercises = new Exercicios();
            var input = new List<int>();

            var result = exercises.xQuatro(input);

            Assert.Equal(0, result);
        }
    }

    public class xCincoTests
    {
        [Fact]
        public void should_return_60()
        {
            var exercises = new Exercicios();
            var input = new List<(string name, int age)>()
            {("Maria", 45), ("Jennifer", 23), ("Laura", 14), ("Fernanda", 35), ("Bianca", 18)};

            double result = exercises.xCinco(input);

            Assert.Equal(60, result);
        }
        
        [Fact]
        public void should_return_62_dot_5()
        {
            var exercises = new Exercicios();
            var input = new List<(string name, int age)>()
            {("Maria", 45), ("Jennifer", 23), ("Laura", 14), ("Fernanda", 35),
            ("Bianca", 18), ("Linda", 89), ("Sarah", 25), ("Ana", 32)};

            double result = exercises.xCinco(input);

            Assert.Equal(62.5, result);
        }
    }

    public class xOitoTests
    {
        [Fact]
        public void should_return_true_when_multiples()
        {
        //Given
        var exercises = new Exercicios();
        double x = 60;
        double y = 3;

        //When
        bool isMultiple = exercises.xOito(x, y);
        
        //Then
        Assert.True(isMultiple);
        }

        [Fact]
        public void should_return_false_when_not_multiples()
        {
        //Given
        var exercises = new Exercicios();
        double x = 54;
        double y = 8;

        //When
        bool isMultiple = exercises.xOito(x, y);
        
        //Then
        Assert.False(isMultiple);
        }
    }
}