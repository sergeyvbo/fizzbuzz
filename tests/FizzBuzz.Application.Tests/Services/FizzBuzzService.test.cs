using FizzBuzz.Application.Services;

namespace FizzBuzz.Application.Tests;

public class FizzBuzzServiceTest
{
    private readonly FizzBuzzService _service = new();

    [Fact]
    public void CalculateFizzBuzz_WhenValidInput_ShouldReturnFizzBuzz()
    {
        //Arrange
        //Act
        var result = _service.CalculateFizzBuzz(["3", "5", "15"]);
        //Assert
        Assert.Equal("Fizz", result.First());
        Assert.Equal("Buzz", result[1]);
        Assert.Equal("FizzBuzz", result[2]);
    }

    [Fact]
    public void CalculateFizzBuzz_WhenInValidInput_ShouldReturnError()
    {
        //Arrange
        //Act
        var result = _service.CalculateFizzBuzz(["", "A"]);
        //Assert
        Assert.NotNull(result);
        result.ForEach(x => Assert.Equal("Invalid item", x));

    }
}