public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string eventTitle, string description, string date, string time, string address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"{_weather}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine($"Outdoor\n{GetEventTitle()}\n{GetDate()}");
    }
}