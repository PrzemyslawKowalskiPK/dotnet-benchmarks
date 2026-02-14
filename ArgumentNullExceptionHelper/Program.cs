using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<ArgumentCheckBenchmarks>();

public class ArgumentCheckBenchmarks
{
    string value = "hello";
    string? nullValue = null;

    [Benchmark]
    public void HelperArgumentNullException_NoThrow_WithoutTryCatch()
    {
        ArgumentNullException.ThrowIfNull(value);
    }

    [Benchmark(Baseline = true)]
    public void IfStatement_NoThrow_WithoutTryCatch()
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }
    }

    [Benchmark]
    public void HelperArgumentNullException_NoThrow_WithTryCatch()
    {
        try
        {
            ArgumentNullException.ThrowIfNull(value);
        }
        catch (ArgumentNullException)
        {
        }
    }

    [Benchmark]
    public void IfStatement_NoThrow_WithTryCatch()
    {
        try
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
        catch (ArgumentNullException)
        {
        }
    }

    [Benchmark]
    public void HelperArgumentNullException_Throw()
    {
        try
        {
            ArgumentNullException.ThrowIfNull(nullValue);
        }
        catch (ArgumentNullException)
        {
        }
    }

    [Benchmark]
    public void IfStatement_Throw()
    {
        try
        {
            if (nullValue is null)
            {
                throw new ArgumentNullException(nameof(nullValue));
            }
        }
        catch (ArgumentNullException)
        {
        }
    }
}
