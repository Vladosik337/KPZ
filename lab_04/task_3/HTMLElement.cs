using System;

class HTMLElement
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public void AddEventListener(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveEventListener(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void TriggerEvent(string eventType)
    {
        Console.WriteLine($"Event '{eventType}' triggered.");
        foreach (var observer in _observers)
        {
            observer.HandleEvent(eventType);
        }
    }
}
