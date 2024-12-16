using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        // Run BenchmarkDotNet benchmarks
        BenchmarkRunner.Run<MemoryLeakBenchmark>();
    }
}
