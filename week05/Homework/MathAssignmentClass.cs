public class MathAssignment : Assignment
{

    private string _textbookSection = "";
    private string _problems = "";

    public void SetTextbook(string textbook)
    {
        _textbookSection = textbook;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"{GetSummary()} Section: {_textbookSection} Problems {_problems}";
    }

}