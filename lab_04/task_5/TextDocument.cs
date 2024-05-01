class TextDocument
{
    public string Content { get; set; }

    public TextDocument(string content)
    {
        Content = content;
    }

    public void Print()
    {
        Console.WriteLine("Current content:");
        Console.WriteLine(Content);
    }
}