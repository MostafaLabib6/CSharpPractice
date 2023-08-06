public class FileSearcher{ 
    
    // Event
    public event EventHandler<FileSearcherEventArgs>? OnSearchCompleted;

    public void Search(string? directory,string filePattern){ 
        
        foreach (var file in Directory.EnumerateFiles(directory,filePattern)){ 
            
            FileSearcherEventArgs e = new(file);

            if(e.Cancelled)
                break;

            OnFileFound(e);
        }
    }

    protected virtual void OnFileFound(FileSearcherEventArgs fileSearcherEventArgs)
    {
        OnSearchCompleted?.Invoke(this, fileSearcherEventArgs);
        
    }

}
