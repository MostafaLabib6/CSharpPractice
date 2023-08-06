public class SearchResultMessage
{
    public void OnFileFound(object source, FileSearcherEventArgs fileSearcherEventArgs)
    {

        // Display Message
        Thread.Sleep(1000);

        Console.WriteLine("Display a Message...");
        Thread.Sleep(2000);

        Console.WriteLine($"Files:{fileSearcherEventArgs.FileName} \n");

    }
}
