using System.Text;
namespace FizzBuzz.Application.Services;

public class FizzBuzzService
{
    public List<string> CalculateFizzBuzz(string[] values)
    {
        return values.Select(x => FizzBuzz(x)).ToList();
    }

    private string FizzBuzz(string? value)
    {
        if (!int.TryParse(value, out int number))
        {
            return "Invalid item";
        }

        StringBuilder stringBuilder = new();
        if (number % 3 == 0)
        {
            stringBuilder.Append("Fizz");
        }
        if (number % 5 == 0)
        {
            stringBuilder.Append("Buzz");
        }
        var result = stringBuilder.ToString();
        if (string.IsNullOrEmpty(result))
        {
            return $"Divided {number} by 3; Divided {number} by 5";
        }
        return result;
    }
}
