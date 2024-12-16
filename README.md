# Avoid CSharp Events in Asp.Net Core

Code to support an article on why you should avoid C# events in ASPNET Core apps:

[Avoid Using C# Events in ASP.NET Core Apps](https://ardalis.com/avoid-using-csharp-events-in-aspnetcore-apps/)

See also: [C# Advent of Code 2024](https://csadvent.christmas/)

## Long Running Demo of Resource Leak

Pull down the code, cd into the LongRunningConsole, and execute `dotnet run`. You'll see something like this:

![Long Running Leak Demo](https://github.com/user-attachments/assets/cd16b043-f8a0-43b3-94dd-08ffa586a2c7)

Note that it starts out showing each line of 1000 iterations every second or so but quickly slows down such that by iteration 260000 it takes 15+ seconds per line. The leak isn't just causing memory problems, but other performance issues as all of the handlers that weren't cleaned up must still be considered with each event raised.
