class LightTextNode : LightNode
{
    private string text;

    public LightTextNode(string text)
    {
        this.text = text;
    }

    public override string OuterHTML()
    {
        return "";
    }

    public override string InnerHTML()
    {
        return text;
    }
}
