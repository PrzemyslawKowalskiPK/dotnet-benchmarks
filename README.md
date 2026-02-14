# dotnet-benchmarks

A collection of micro-benchmarks for .NET, focusing on performance comparisons of various coding patterns and framework helpers.

## Current Benchmarks

### [ArgumentNullExceptionHelper](./ArgumentNullExceptionHelper)

This benchmark compares the performance of the modern `ArgumentNullException.ThrowIfNull` helper against traditional `if` statement null checks.

- **Target Framework:** .NET 10
- **Library:** BenchmarkDotNet

## How to Run

To run the `ArgumentNullExceptionHelper` benchmark:

1. Navigate to the project directory:
   ```bash
   cd ArgumentNullExceptionHelper
   ```
2. Run in Release mode:
   ```bash
   dotnet run -c Release
   ```
