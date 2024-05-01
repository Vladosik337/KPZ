class FileLoggerAdapter : ILogger
{
    private FileWriter fileWriter;

    public FileLoggerAdapter(FileWriter fileWriter)
    {
        this.fileWriter = fileWriter;
    }

    public void Log(string message)
    {
        fileWriter.Write($"[Log] {message}");
    }

    public void Error(string message)
    {
        fileWriter.Write($"[Error] {message}");
    }

    public void Warn(string message)
    {
        fileWriter.Write($"[Warn] {message}");
    }
}