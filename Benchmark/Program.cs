// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<PrimeNumBenchmark>();

[MemoryDiagnoser]
public class PrimeNumBenchmark
{
    [Benchmark]
    public void Method1()
    {
        PrimeNumberGenerator.PrimeNumbersUpTo(10000);
    }

}
