using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length; // in minutes

    public DateTime Date { get => _date; set => _date = value; }
    public int Length { get => _length; set => _length = value; }

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name}: {Length} min, Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
