public class WritingAssignment : Assignment
{
    private string _title = "";

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()} \n{_title} by: {GetStudentName()}";
    }

}