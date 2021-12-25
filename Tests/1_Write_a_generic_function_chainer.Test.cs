using Xunit;
using Write_a_generic_function_chainer;

namespace Test_write_a_generic_function_chainer;

 public class Test_write_a_generic_function_chainer
 {
    [Fact]
    public void Fact1()
    {
       // Arrange
       var add = (double x) => x + 10;
       var mul = (double x) => x * 30;
       var funcArr = new[] { add, mul };
       double inputNumber = 2;
       double expectedResult = 360;
    
       // Act
       double actualResult = Kata.Chain(inputNumber, funcArr);
    
       // Assert
       Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Fact2()
    {
        // Arrange
        var add = (double x) => x + 1;
        var mul = (double x) => x * 30;
        var funcArr = new[] { add, mul };
        double inputNumber = 2;
        double expectedResult = 90;
    
        // Act
        double actualResult = Kata.Chain(inputNumber, funcArr);
    
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

}
