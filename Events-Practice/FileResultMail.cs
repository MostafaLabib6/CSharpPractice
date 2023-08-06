
FileSearcher fileSearcher = new();
SearchResultMail searchResultMail = new();
SearchResultMessage searchResultMessage = new();

fileSearcher.OnSearchCompleted += searchResultMail.OnFileFound;
fileSearcher.OnSearchCompleted += searchResultMail.OnFileFound;


fileSearcher.Search(@"test","*.txt");






public class SearchResultMail
{
    public void OnFileFound(object source, FileSearcherEventArgs fileSearcherEventArgs)
    {

        // Sending mail
        Thread.Sleep(1000);

        Console.WriteLine("Sending Mail...");
        Thread.Sleep(2000);


        Console.WriteLine($"Files:{fileSearcherEventArgs.FileName} \n");

    }
}