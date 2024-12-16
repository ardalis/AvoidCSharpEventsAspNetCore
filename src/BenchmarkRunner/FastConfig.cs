using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

public class FastConfig : ManualConfig
{
    public FastConfig()
    {
        AddJob(Job.Default
            .WithWarmupCount(1)  // One warmup iteration
            .WithIterationCount(3)  // Three actual benchmark iterations
        );
    }
}