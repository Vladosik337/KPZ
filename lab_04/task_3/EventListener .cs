using System;

class EventListener : IObserver
{
    private readonly string _eventType;

    public EventListener(string eventType)
    {
        _eventType = eventType;
    }

    public void HandleEvent(string eventType)
    {
        if (eventType == _eventType)
        {
            Console.WriteLine($"Event '{_eventType}' handled.");
        }
    }
}