
Logger logger = new();

LogConosoleMessage logConosoleMessage = new();
LogFileMessage logFileMessage = new("log.txt");

Logger.loggerHandler = logConosoleMessage.LogToConsole;
Logger.loggerHandler += logFileMessage.LoggineToFile;

logger.Logging(s: Severity.Error);






