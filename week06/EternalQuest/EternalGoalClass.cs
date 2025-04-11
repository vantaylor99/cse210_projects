public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        Console.WriteLine($"+ {_points} Points");
    }

    public override int GetPoints()
    {
        return _points;
    }


    public override string GetStatus()
    {
        return $"[∞] {_name}";
    }

    public EternalGoal(string name, int points) : base(name, points)
    {
        _name = name;
        _points = points;
    }

    public override string ToFileFormat()
    {
        return $"EternalGoal|{_name}|{_points}";
    }
}