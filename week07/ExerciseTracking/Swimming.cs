using System;

public class Swimming : Activity
{
    private int _laps; // number of laps

    public int Laps { get => _laps; set => _laps = value; }

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // 50 meters per lap converted to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Length / 60.0);
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }
}
