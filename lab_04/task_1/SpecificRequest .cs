class SpecificRequest : SupportRequest
{
    public override void HandleRequest(int level)
    {
        Console.WriteLine("Handling specific request...");
        if (NextHandler != null && level >= 1)
        {
            NextHandler.HandleRequest(level);
        }
    }
}