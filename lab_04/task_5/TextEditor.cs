class TextEditor
{
    private TextDocument _document;
    private TextDocumentMemento _memento;

    public TextEditor(TextDocument document)
    {
        _document = document;
    }

    public void Save()
    {
        _memento = new TextDocumentMemento(_document.Content);
        Console.WriteLine("Document saved.");
    }

    public void Undo()
    {
        if (_memento != null)
        {
            _document.Content = _memento.Content;
            Console.WriteLine("Undo successful.");
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    public void Print()
    {
        _document.Print();
    }

    public void Edit(string newContent)
    {
        _document.Content = newContent;
        Console.WriteLine("Document edited.");
    }
}