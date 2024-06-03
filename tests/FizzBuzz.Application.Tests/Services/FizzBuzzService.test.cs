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
        var result = _service.CalculateFizzBuzz(["3"]);
        //Assert
        Assert.Equal("Fizz", result.First());
    }
}