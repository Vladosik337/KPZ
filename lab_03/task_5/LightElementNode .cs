using System.Text;

class LightElementNode : LightNode
{
    private string tag;
    private string displayType;
    private string closingType;
    private List<string> classes;
    private List<LightNode> children;

    public LightElementNode(string tag, string displayType, string closingType, List<string> classes, List<LightNode> children)
    {
        this.tag = tag;
        this.displayType = displayType;
        this.closingType = closingType;
        this.classes = classes;
        this.children = children;
    }

    public override string OuterHTML()
    {
        StringBuilder html = new StringBuilder();
        html.Append($"<{tag}");

        if (classes.Count > 0)
        {
            html.Append(" class=\"");
            html.Append(string.Join(" ", classes));
            html.Append("\"");
        }

        html.Append(">");

        foreach (var child in children)
        {
            html.Append(child.OuterHTML());
        }

        if (closingType == "closing")
        {
            html.Append($"</{tag}>");
        }
        else if (closingType == "selfClosing")
        {
            html.Append("/>");
        }

        return html.ToString();
    }

    public override string InnerHTML()
    {
        StringBuilder html = new StringBuilder();

        foreach (var child in children)
        {
            html.Append(child.OuterHTML());
        }

        return html.ToString();
    }
}