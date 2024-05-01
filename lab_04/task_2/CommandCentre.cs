class CommandCentre
{
    public event EventHandler<string> RequestTakeoff;
    public event EventHandler<string> RequestLanding;

    public void RequestToTakeoff(string aircraftName)
    {
        Console.WriteLine($"Command Centre: Request received for {aircraftName} to take off.");
        RequestTakeoff?.Invoke(this, aircraftName);
    }

    public void RequestToLand(string aircraftName)
    {
        Console.WriteLine($"Command Centre: Request received for {aircraftName} to land.");
        RequestLanding?.Invoke(this, aircraftName);
    }
}