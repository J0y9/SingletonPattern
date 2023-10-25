using SingletonPattern;

public class ConsoleLog : ILogger
{
    public void LogError(string message)
    {
        Console.WriteLine($"ConsoleLogError: {message}");
    }

    public void LogInfo(string message)
    {
        Console.WriteLine($"ConsoleLogInfo: {message}");

    }
}