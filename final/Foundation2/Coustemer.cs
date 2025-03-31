class Coustemer
{

    private string _name;
    private Address _address;
    
    public Coustemer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetIsUSA()
    {
        return _address.GetIsUSA();
    }

    public string GetShippingLabel()
    {
        return $"Name: {_name}\nAddress: {_address.GetAddress()}";
    }



}