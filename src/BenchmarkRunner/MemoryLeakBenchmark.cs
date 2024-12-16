using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
[Config(typeof(FastConfig))]
public class MemoryLeakBenchmark
{
    private EventPublisher _publisher;

    [GlobalSetup]
    public void Setup()
    {
        _publisher = new EventPublisher();
    }

    [Benchmark]
    public void CauseLeak()
    {
        var subscriber = new EventSubscriber(_publisher);
        _publisher.RaiseEvent();
    }

    [Benchmark]
    public void ProperlyDisposeSubscriber()
    {
        using var subscriber = new FixedSubscriber(_publisher);
        _publisher.RaiseEvent();
    }
}
