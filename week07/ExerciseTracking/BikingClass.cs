public class Biking : Activity
{


    private float _distance;

    public Biking(string date, float minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
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
