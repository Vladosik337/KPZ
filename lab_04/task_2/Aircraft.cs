class Aircraft
{
    private readonly string _name;
    private readonly CommandCentre _commandCentre;

    public Aircraft(string name, CommandCentre commandCentre)
    {
        _name = name;
        _commandCentre = commandCentre;
        _commandCentre.RequestTakeoff += OnRequestTakeoff;
        _commandCentre.RequestLanding += OnRequestLanding;
    }

    public void RequestTakeoff()
    {
        _commandCentre.RequestToTakeoff(_name);
    }

    public void RequestLanding()
    {
        _commandCentre.RequestToLand(_name);
    }

    private void OnRequestTakeoff(object sender, string aircraftName)
    {
        if (aircraftName == _name)
        {
            Console.WriteLine($"{_name}: Clearance granted for takeoff.");
        }
    }

    private void OnRequestLanding(object sender, string aircraftName)
    {
        if (aircraftName == _name)
        {
            Console.WriteLine($"{_name}: Clearance granted for landing.");
        }
    }
}