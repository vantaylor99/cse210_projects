public abstract class Activity
{
    private float _lengthMinutes;

    private string _date;

    public Activity(string date, float lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public float GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }
    
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetSummary()
    {
        return ($"{GetDate()} {this.GetType().Name} ({GetLengthMinutes()} min) - ") + $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
