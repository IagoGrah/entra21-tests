using Xunit;

namespace entra21_tests
{
    public class ExerciciosTest
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