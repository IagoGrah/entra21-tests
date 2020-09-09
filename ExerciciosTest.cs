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

    public class xSeteTests
    {
        [Fact]
        public void should_return_4197_dot_5()
        {
            var exercises = new Exercicios();

            var result = exercises.xSete(4, 23, 2.50);

            Assert.Equal(4197.5, result);
        }
    }
    
    public class xOitoTests
    {
        [Fact]
        public void should_return_true_when_multiples()
        {
            //Given
            var exercises = new Exercicios();

            //When
            bool isMultiple = exercises.xOito(60, 3);
            
            //Then
            Assert.True(isMultiple);
        }

        [Fact]
        public void should_return_false_when_not_multiples()
        {
            //Given
            var exercises = new Exercicios();

            //When
            bool isMultiple = exercises.xOito(54, 8);
            
            //Then
            Assert.False(isMultiple);
        }
    }

    public class xNoveTests
    {
        [Fact]
        public void should_return_false_when_x_smaller_than_sum_of_y_and_z()
        {
            var exercises = new Exercicios();

            bool isBiggerThanSum = exercises.xNove(34.2, 12.76543, 67);

            Assert.False(isBiggerThanSum);
        }

        [Fact]
        public void should_return_true_when_x_bigger_than_sum_of_y_and_z()
        {
            var exercises = new Exercicios();

            bool isBiggerThanSum = exercises.xNove(9999, 0.0005, 15.123521345);

            Assert.True(isBiggerThanSum);
        }
    }

    public class xTrezeTests
    {
        [Fact]
        public void should_return_167()
        {
            var exercises = new Exercicios();
            var myList = new List<double>()
            {65.2, 89.1, 58, 167, -54, 0};

            double result = exercises.xTreze(myList);

            Assert.Equal(167, result);
        }

        [Fact]
        public void should_return_n12()
        {
            var exercises = new Exercicios();
            var myList = new List<double>()
            {-15.2, -676.3, -12};

            double result = exercises.xTreze(myList);

            Assert.Equal(-12, result);
        }
    }

    public class xDezoitoTests
    {
        [Fact]
        public void should_return_33dot1()
        {
            var exercises = new Exercicios();

            double result = exercises.xDezoito(31);

            Assert.Equal(33.1, result);
        }

        [Fact]
        public void should_return_24()
        {
            var exercises = new Exercicios();

            double result = exercises.xDezoito(24);

            Assert.Equal(24, result);
        }
    }
}