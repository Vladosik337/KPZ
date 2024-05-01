class SmartTextChecker : ITextReader
{
    private SmartTextReader textReader;

    public SmartTextChecker()
    {
        this.textReader = new SmartTextReader();
    }

    public string[,] ReadText(string filePath)
    {
        Console.WriteLine("Opening file: " + filePath);
        string[,] text = textReader.ReadText(filePath);
        Console.WriteLine("Reading file: " + filePath);
        Console.WriteLine($"Total rows: {text.GetLength(0)}, Total columns: {text.GetLength(1)}");
        Console.WriteLine("Closing file: " + filePath);
        return text;
    }
}