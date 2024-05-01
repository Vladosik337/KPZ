abstract class SupportRequest
{
    protected SupportHandler NextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        NextHandler = handler;
    }

    public abstract void HandleRequest(int level);
}