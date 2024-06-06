public class Event
{
    private string _title, _description, _date, _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"{_title} - {_description}\n{_date} @ {_time}\n{_address.DisplayAddress()}\n";
    }

    public string GetShortDetails()
    {
        return $"{this.GetType().Name} - {_description} - {_date}\n====================================\n";
    }
}