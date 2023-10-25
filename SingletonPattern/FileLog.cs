using SingletonPattern;

public class FileLog : ILogger
{
    public void LogError(string message)
    {
        Console.WriteLine($"FileLogError: {message}");

    }

    public void LogInfo(string message)
    {
        Console.WriteLine($"FileLogInfo: {message}");

    }
}