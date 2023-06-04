// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<PrimeNumBenchmark>();

[MemoryDiagnoser]
public class PrimeNumBenchmark
{// Run the benchmark to determine which implementation is faster (more performance and which takes less memory)
    [Benchmark]
    public void PrimeNumbersUpToMethod()
    {
        PrimeNumberGenerator.PrimeNumbersUpTo(10000);
    }

    [Benchmark]
    public void PrintPrimeNumbersMethod()
    {
        PrimeNumberGenerator.PrintPrimeNumbers(10000);
    }
}
