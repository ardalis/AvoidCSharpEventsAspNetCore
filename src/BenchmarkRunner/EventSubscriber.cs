
public class EventSubscriber
{
    private readonly EventPublisher _publisher;

    public EventSubscriber(EventPublisher publisher)
    {
        _publisher = publisher;
        _publisher.SomethingHappened += OnSomethingHappened;
    }

    private void OnSomethingHappened(object? sender, EventArgs e)
    {
        //Console.WriteLine("Event received.");
    }
}
