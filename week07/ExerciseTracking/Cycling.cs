using System;

public class Cycling : Activity
{
    private double _speed; // in kilometers per hour

    public double Speed { get => _speed; set => _speed = value; }

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (Length / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }
}
