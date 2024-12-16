var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

var publisher = new EventPublisher();

app.MapGet("/", () =>
{
    // Creates a new subscriber on every request
    var subscriber = new EventSubscriber(publisher);
    publisher.RaiseEvent();
    return "Event raised!";
});
app.Run();
