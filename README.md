# Callisto.Helix

Simple Result Wrapper

## Installation

Install the package from NuGet:

```bash
dotnet add package Callisto.Helix
```

## Usage

### Basic

```csharp
// Program.cs
using Callisto.Helix;

public HelixResult TaskWithoutResult()
{
    if (input < 0)
    {
        return HelixResult.Failed("Input must be greater than 0");
    }

    return HelixResult.Success();
}

public HelixValueResult<T> TaskWithResultAndObject(int input)
{
    if (input < 0)
    {
        return HelixValueResult<T>.Failed("Input must be greater than 0");
    }

    return HelixValueResult<T>.Success(new T { Value = input });
}
```
