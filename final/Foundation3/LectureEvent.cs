public class LectureEvent : Event
{

    private string _speakerName;
    private int _capacity;

    public LectureEvent(string eventTitle, string description, string date, string time, string address, string speakerName, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"{_speakerName}\n{_capacity}");

    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine($"Lecture\n{GetEventTitle()}\n{GetDate()}");
    }
}