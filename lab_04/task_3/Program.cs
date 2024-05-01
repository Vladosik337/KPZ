interface IObserver
{
    void HandleEvent(string eventType);
}

class Program
{
    static void Main(string[] args)
    {
        HTMLElement element = new HTMLElement();

        EventListener clickListener = new EventListener("click");
        EventListener mouseoverListener = new EventListener("mouseover");

        element.AddEventListener(clickListener);
        element.AddEventListener(mouseoverListener);

        element.TriggerEvent("click");
        element.TriggerEvent("mouseover");
    }
}