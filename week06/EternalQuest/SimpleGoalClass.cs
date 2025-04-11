public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }

    public override int GetPoints()
    {
        return _points;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStatus()
    {
        string _status = "";
        

        if (_isComplete == true)
        {
            _status = "[X]";
        }

        else
        {
            _status = "[ ]";
        }

        return $"{_status} {_name}";

    }

    public override string ToFileFormat()
    {
        return $"SimpleGoal|{_name}|{_points}|{_isComplete}";
    }
}