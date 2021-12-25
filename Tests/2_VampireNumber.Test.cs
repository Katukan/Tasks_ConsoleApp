using Xunit;
using Vampire_Numbers;

namespace VampireNumber.Test;

public class VampireNumber
{
    [Fact]
    public void Fact1()
    {
        // Arrange
        int firstArgument = 21;
        int secondArgument = 6;

        // Act
        bool actualResult = Kata.vampire_test(firstArgument, secondArgument);

        // Assert
        Assert.True(actualResult); // Basic: 21 * 6 = 126 should return True
    }

    [Fact]
    public void Fact2()
    {
        // Arrange
        int firstArgument = 204;
        int secondArgument = 615;

        // Act
        bool actualResult = Kata.vampire_test(firstArgument, secondArgument);

        // Assert
        Assert.True(actualResult);  // "Basic: 204 * 615 = 125460 should return True";
    }

    [Fact]
    public void Fact3()
    {
        // Arrange
        int firstArgument = 30;
        int secondArgument = -51;

        // Act
        bool actualResult = Kata.vampire_test(firstArgument, secondArgument);

        // Assert
        Assert.True(actualResult);  // "One Negative: 30 * -51 = -1530 should return True"
    }

    [Fact]
    public void Fact4()
    {
        // Arrange
        int firstArgument = -246;
        int secondArgument = -510;

        // Act
        bool actualResult = Kata.vampire_test(firstArgument, secondArgument);

        // Assert
        Assert.False(actualResult);  // "Double Negatives: -246 * -510 = 125460 should return False (The negative signs aren't present on the product)"
    }

    [Fact]
    public void Fact5()
    {
        // Arrange
        int firstArgument = 210;
        int secondArgument = 600;

        // Act
        bool actualResult = Kata.vampire_test(firstArgument, secondArgument);

        // Assert
        Assert.True(actualResult);  // "Trailing Zeroes: 210 * 600 = 126000 should return True"
    }
}
