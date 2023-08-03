public class LogFileMessage
{
    private readonly string _logPath;
    public LogFileMessage(string logPath)
    {
        this._logPath = logPath;
    }
    public void LoggineToFile(string message)
    {
        try
        {
            using (var log = File.AppendText(_logPath))
            {
                log.WriteLine(message);
                log.Flush();
            }
        }
        catch (Exception)
        {
            // Hmm. We caught an exception while
            // logging. We can't really log the
            // problem (since it's the log that's failing).
            // So, while normally, catching an exception
            // and doing nothing isn't wise, it's really the
            // only reasonable option here.

        }
    }
}