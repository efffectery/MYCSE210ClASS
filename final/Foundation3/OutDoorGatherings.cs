class OutDoorGatherings : Event
{
    private string _weatherForeCast;

    public OutDoorGatherings(string title, string description, string date, string time, Address address, string type, string weatherForeCast) : base(title, description, date, time, address, type)
    {
        _weatherForeCast = weatherForeCast;
    }

    
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"WeatherForeCast: {_weatherForeCast}");
    }


}