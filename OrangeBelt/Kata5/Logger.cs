namespace Kata5;

public class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}