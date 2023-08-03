public class Logger
{
    private string? _message;
    public static Action<string>? loggerHandler;
    private readonly Severity severity = Severity.Warning;

    public void Logging(string? message = null, Severity s = Severity.Error)
    {
        // check if Non Critical Error Happend 
        if (s < severity)
            return;

        _message = $"Message Date: {DateTime.Now}\nMessage Content:{message ?? "Empty Log Message"}\nMessage Severity:{severity}";


        // Handle Null Delegates
        // Mean that Delegate Have no Subscribers yat.
        loggerHandler?.Invoke(_message);


        // equivlant to => loggerHandler?.Invoke(_message);

        //if (loggerHandler is not null)
        //    loggerHandler(_message);

    }

}
