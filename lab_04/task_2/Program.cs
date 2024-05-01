class Program
{
    static void Main(string[] args)
    {
        CommandCentre commandCentre = new CommandCentre();
        Aircraft aircraft1 = new Aircraft("Flight 123", commandCentre);
        Aircraft aircraft2 = new Aircraft("Flight 456", commandCentre);

        Runway runway = new Runway(commandCentre);

        aircraft1.RequestTakeoff();
        aircraft2.RequestLanding();
    }
}