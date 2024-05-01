using System.Text.RegularExpressions;

class SmartTextReaderLocker : ITextReader
{
    private SmartTextReader textReader;
    private Regex filePattern;

    public SmartTextReaderLocker(string pattern)
    {
        this.textReader = new SmartTextReader();
        this.filePattern = new Regex(pattern);
    }

    public string[,] ReadText(string filePath)
    {
        if (filePattern.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return null;
        }
        else
        {
            return textReader.ReadText(filePath);
        }
    }
}