using FizzBuzz.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<FizzBuzzService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/fizzbuzz", (string[] values, FizzBuzzService fizzBuzzService) =>
{
    if (values is null)
    {
        return Results.BadRequest();
    }
    var result = fizzBuzzService.CalculateFizzBuzz(values);
    return Results.Ok(result);
})
.WithName("GetFizzBuzz")
.WithOpenApi();

app.Run();
