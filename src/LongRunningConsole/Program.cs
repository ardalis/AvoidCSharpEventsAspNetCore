using System;

public class Program
{
    public static void Main(string[] args)
    {
        var publisher = new EventPublisher();

        Console.WriteLine("Press any key to start the leak simulation...");
        Console.ReadKey();

        for (int i = 0; i < 1_000_000; i++)
        {
            // Create a new leaking subscriber
            var subscriber = new LeakySubscriber(publisher);

            // Optionally raise an event to simulate activity
            publisher.RaiseEvent();

            // Periodically log memory usage
            if (i % 10_000 == 0)
            {
                Console.WriteLine($"Iteration: {i}, Memory: {GC.GetTotalMemory(false):N0} bytes");
            }
        }

        Console.WriteLine("Leak simulation complete. Press any key to exit...");
        Console.ReadKey();
    }
}

public class EventPublisher
{
    public event EventHandler? SomethingHappened;

    public void RaiseEvent()
    {
        SomethingHappened?.Invoke(this, EventArgs.Empty);
    }
}

public class LeakySubscriber
{
    public LeakySubscriber(EventPublisher publisher)
    {
        publisher.SomethingHappened += OnSomethingHappened;
    }

    private void OnSomethingHappened(object? sender, EventArgs e)
    {
        // Simulate doing nothing
    }
}
