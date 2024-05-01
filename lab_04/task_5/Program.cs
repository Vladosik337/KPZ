class Program
{
    static void Main(string[] args)
    {
        TextDocument document = new TextDocument("Initial content");

        TextEditor editor = new TextEditor(document);

        editor.Print();
        editor.Edit("New content");
        editor.Save();

        editor.Edit("Even newer content");
        editor.Save();

        editor.Undo();

        editor.Print();
    }
}