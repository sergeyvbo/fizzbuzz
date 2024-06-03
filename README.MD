# Take home coding exercise: Fizz Buzz

## Background

Please develop a web application in C# or NodeJS that accepts an array of values. The application should do the following for each value in the array:
1. If the value is a multiple of 3 then output the word “Fizz”
2. If the value is a multiple of 5 then output the word “Buzz”
3. If the value is divisible by both 3 and 5 then output the word “FizzBuzz”
4. At the end of the run the program should display each division that was performed.

The table below shows a list of inputs and their corresponding expected outputs.

| Input | Result |
| --- | --- |
| 1 | Divided 1 by 3 Divided 1 by 5 |
| 3 | Fizz |
| 5 | Buzz |
| <empty |> Invalid Item |
| 15 | FizzBuzz |
| A | Invalid item |
| 23 | Divided 23 by 3 Divided 23 by 5 |

## Assignment

Feel free to be as creative as you like. You could host this in a cloud environment of your choice, local containerized environment, or simply provide a local script to start your application. You can use any tools or libraries that you feel help you meet the requirements. Additionally, you may use any of the language features available within the language version of your choice. However, we at least expect your solution to demonstrate the following:

- Single Responsibility

- Separation Of Concerns

- Test Automation (Unit and/or Integration)

If you have any questions regarding the requirements you can either ask for clarification or make assumptions. Please briefly include any assumptions you make with your solution.

## Submission

The preferred way is to submit your example via www.github.com. Name your repository "FizzBuzz" and send the url to your point of contact with "FizzBuzz" on the subject line. Optionally, you can zip up your solution and send it to your recruiter.

Enjoy!

# Usage
1. Clone the repository `git clone https://github.com/sergeyvbo/fizzbuzz.git`
2. `cd fizzbuzz`
3. `dotnet run --project .\src\FizzBuzz.Api\FizzBuzz.Api.csproj`
3. Navigate to `http://localhost:5003/swagger/index.html` (your port may be different)
4. Use Swagger to test the api

# Assumptions
1. If the input values can't be parsed to integer, then it's an invalid item
2. if the input value is divisible by 3 or 5, we do not output "Divided x by 3, Divided x by 5" according to the table
3. User interface is out of scope of this solution

## Single responsibility
Since this is a very simple application, we parse and process the input array in the same class, but if the input values become more complex, we can create a separate class for input validation.

## Separation of Concerns
Api, Business logic, and unit tests for our application are located in separate projects which enables us to maintain each part of the project individually. This is a very simple project, so I decided to keep it simple and not add abstractions such as IFizzBuzzService interface at this time

## Test Automation
Some xUnit tests were added to test our business logic invariants. 

# Future improvements
## Publish to Docker
A Dockerfile can be used to deploy the application as a Docker container.
## Publish to Azure Cloud or AWS
GitHub actions can be created to deploy the application in Azure or AWS. There are predefined actions in the Github store that require minimum configuration.