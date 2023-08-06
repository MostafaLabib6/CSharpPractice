public class FileSearcherEventArgs: EventArgs{
    public bool Cancelled { get; set; }
    public string? FileName { get; set; }

    public FileSearcherEventArgs(string fileName)
    {
        FileName = fileName;
    }


}
