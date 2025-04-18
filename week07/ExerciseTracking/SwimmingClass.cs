public class Swimming : Activity
{


    private int _laps;

    public Swimming(string date, float minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * (50f / 1000f);
    }
    public override float GetSpeed()
    {
        float distance = GetDistance();
        float minutes = GetLengthMinutes();
        return (distance / minutes) * 60;
    }
    public override float GetPace()
    {
        float distance = GetDistance();
        float minutes = GetLengthMinutes();
        return (minutes / distance);
    }

}
