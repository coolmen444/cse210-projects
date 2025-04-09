public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    public override double GetSpeed()
    {
       return (_distance / GetLength()) * 60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min)- Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}