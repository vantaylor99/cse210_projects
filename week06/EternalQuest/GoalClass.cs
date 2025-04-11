public abstract class Goal
{
    protected string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract string GetStatus();

    public abstract int GetPoints();

    public abstract string ToFileFormat();



}