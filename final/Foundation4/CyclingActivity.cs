public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
        {
        return (_speed * GetLength()) / 60;
        }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min)- Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}