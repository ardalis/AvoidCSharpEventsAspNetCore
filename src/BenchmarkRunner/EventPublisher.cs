public class EventPublisher
{
    public event EventHandler? SomethingHappened;

    public void RaiseEvent()
    {
        SomethingHappened?.Invoke(this, EventArgs.Empty);
    }
}
