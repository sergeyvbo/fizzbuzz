# Use the official .NET 8 SDK image to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory for the build stage
WORKDIR /src

# Copy the .NET projects
COPY src/FizzBuzz.Api/FizzBuzz.Api.csproj ./FizzBuzz.Api/
COPY src/FizzBuzz.Application/FizzBuzz.Application.csproj ./FizzBuzz.Application/

# Copy the rest of the project files
COPY src/ .

# Restore the dependencies
RUN dotnet restore FizzBuzz.Api/FizzBuzz.Api.csproj

# Build the application
RUN dotnet publish FizzBuzz.Api/FizzBuzz.Api.csproj -c Release -o /app/publish

# Use the official .NET 8 runtime image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the published files from the build stage
COPY --from=build /app/publish .

# Expose the port the application runs on
EXPOSE 80

# Define the entry point for the container
ENTRYPOINT ["dotnet", "FizzBuzz.Api.dll"]
