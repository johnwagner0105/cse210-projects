public class Customer
{
    private Address _address;
    private string _name;

    public Customer(Address address, string name)
    {
        _address = address;
        _name = name;
    }

    public bool IsCustomerInUsa()
    {
        return _address.IsUsa();
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

}