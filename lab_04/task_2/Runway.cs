class Runway
{
    private readonly CommandCentre _commandCentre;

    public Runway(CommandCentre commandCentre)
    {
        _commandCentre = commandCentre;
        _commandCentre.RequestTakeoff += OnRequestTakeoff;
        _commandCentre.RequestLanding += OnRequestLanding;
    }

    private void OnRequestTakeoff(object sender, string aircraftName)
    {
        Console.WriteLine($"Runway: Clearance granted for {aircraftName} to take off.");
    }

    private void OnRequestLanding(object sender, string aircraftName)
    {
        Console.WriteLine($"Runway: Clearance granted for {aircraftName} to land.");
    }
}
