class LevelOneSupportHandler : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level == 1)
        {
            Console.WriteLine("Handling request at Level One support...");
        }
        else if (NextHandler != null)
        {
            NextHandler.HandleRequest(level);
        }
    }
}