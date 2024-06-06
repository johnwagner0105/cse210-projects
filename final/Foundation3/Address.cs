public class Address
{
    private string _street, _city, _stateProv, _country;

    public Address(string street, string city, string stateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }
    public bool IsUsa()
    {
        if (_country != "USA")
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public string DisplayAddress()
    {
        return $"{_street}\n{_city}, {_stateProv}, {_country}";

    }
}