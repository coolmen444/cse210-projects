using System.ComponentModel.DataAnnotations;

public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(string date, double length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (double)_numberOfLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override double GetSpeed()
    {
       return 60 / GetPace();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min)- Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}