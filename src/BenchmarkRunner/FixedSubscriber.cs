public class FixedSubscriber : IDisposable
{
    private readonly EventPublisher _publisher;

    public FixedSubscriber(EventPublisher publisher)
    {
        _publisher = publisher;
        _publisher.SomethingHappened += OnSomethingHappened;
    }

    private void OnSomethingHappened(object? sender, EventArgs e)
    {
        //Console.WriteLine("Event received.");
    }

    public void Dispose()
    {
        _publisher.SomethingHappened -= OnSomethingHappened;
    }
}
