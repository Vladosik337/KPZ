class Program
{
    static void Main(string[] args)
    {
        SupportRequest request = new SpecificRequest();
        SupportHandler levelOneHandler = new LevelOneSupportHandler();

        request.SetNextHandler(levelOneHandler);

        request.HandleRequest(1); 
    }
}