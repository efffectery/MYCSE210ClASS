class Receptions : Event
{
    private string _rsvp;


    public Receptions(string title, string description, string date, string time, Address address, string type, string rsvp) : base(title, description, date, time, address, type)
    {
        _rsvp = rsvp;
    }
    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"RSVP EMAIL: {_rsvp}");
    }




}