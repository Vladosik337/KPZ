using System.IO;

interface ITextReader
{
    string[,] ReadText(string filePath);
}

class Program
{
    static void Main(string[] args)
    {
        ITextReader textChecker = new SmartTextChecker();
        string[,] text = textChecker.ReadText("sample.txt");

        ITextReader textLocker = new SmartTextReaderLocker(@"restricted.*");
        string[,] restrictedText = textLocker.ReadText("restricted_file.txt");
    }
}