using SingletonPattern;

public class Logger
{
    private static readonly Logger _instance = new ();

    private Logger()
    {

    }

    public static Logger CreateInstance()
    {
        return _instance;
    }

    public void LogMessage(ILogger logger, string message)
    {
        logger.LogError(message);
        logger.LogInfo(message);
    }

}