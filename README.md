# Prime Sieve in C#

This is a simple C# implementation of the Sieve of Eratosthenes algorithm for finding prime numbers. It includes unit tests using xUnit and a GitHub Actions workflow for continuous integration.

## Project Structure

- `PrimeSieve/` - Contains the implementation of the prime number generator.
- `PrimeSieve.Tests/` - Contains unit tests for the generator using xUnit.
- `.github/workflows/ci.yml` - GitHub Actions workflow to build and test the project.

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- C# Extension for VS Code

## Setup Instructions

1. **Clone or download this repository.**

2. **Open the folder in VS Code:**
   ```
   code PrimeSieveCSharp
   ```

3. **Restore dependencies:**
   ```
   dotnet restore
   ```

4. **Build the solution:**
   ```
   dotnet build
   ```

5. **Run the tests:**
   ```
   dotnet test
   ```

## GitHub Actions

This project includes a GitHub Actions workflow that automatically runs tests on push and pull request to the `main` branch.

## License

This project is provided for educational purposes.
