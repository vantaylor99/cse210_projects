public class ChecklistGoal : Goal
{
    private bool _isComplete;
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;


    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int GetPoints()
    {
        return _points;
    }



    public override void RecordEvent()
    {
        ++_currentCount;
        if (_currentCount == _targetCount)
        {
            _isComplete = true;
            Console.WriteLine($"+{_bonusPoints} bonus points.");
        }
        else
        {
            Console.WriteLine($"+{GetPoints()} Points.");
            _isComplete = false;
        }
    }


    public override string GetStatus()
    {
        string status = "";
        if (_isComplete == true)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }

        return status;

    }

    public void SetProgress(int currentCount, bool isComplete)
    {
        _currentCount = currentCount;
        _isComplete = isComplete;
        
    }

    public override string ToFileFormat()
    {
        return $"Cheklist Goal|{_name}|{_points}|{_isComplete}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}