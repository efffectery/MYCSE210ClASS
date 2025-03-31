using System.Net.Sockets;

class Event
{

    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}, Description: {_description}\nDate: {_date}, Time: {_time}, Address: {_address.GetAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Type: {_type}, Title: {_title}, Date: {_date}");
    }

}