public class EventSubscriber
{
    public EventSubscriber(EventPublisher publisher)
    {
        // Subscribing to the event but never unsubscribing
        publisher.SomethingHappened += OnSomethingHappened;
    }

    private void OnSomethingHappened(object? sender, EventArgs e)
    {
        Console.WriteLine("Event received.");
    }
}
