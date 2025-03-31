using System.Runtime.InteropServices.Swift;

class Lectures : Event
{
    private string _speaker;
    private int _capacity;


    public Lectures(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"Speaker: {_speaker}, Capacity: {_capacity}");
    }
}