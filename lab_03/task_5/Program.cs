class Program
{
    static void Main(string[] args)
    {
        var root = new LightElementNode("div", "block", "closing", new List<string>(), new List<LightNode>
        {
            new LightElementNode("h1", "block", "closing", new List<string>(), new List<LightNode>
            {
                new LightTextNode("Hello, LightHTML!")
            }),
            new LightElementNode("ul", "block", "closing", new List<string>(), new List<LightNode>
            {
                new LightElementNode("li", "block", "closing", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Item 1")
                }),
                new LightElementNode("li", "block", "closing", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Item 2")
                }),
                new LightElementNode("li", "block", "closing", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Item 3")
                })
            })
        });

        Console.WriteLine(root.OuterHTML());
    }
}