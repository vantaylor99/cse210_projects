using System.Runtime.CompilerServices;

public class Ref
{
    private List<string> _scriptureReference = new List<string>();
    public Ref(string scriptureReference)
    {
        foreach (string word in scriptureReference.Split(' '))
        {
            _scriptureReference.Add(word);
        }
    }

    private string _scriptureReferenceBook = "";
    private int _scriptureReferenceChapter = 0;
    private int _scriptureReferenceVerse = 0;

    public void ParseReference()
    {
        if (_scriptureReference.Count >= 3)
        {
            _scriptureReferenceBook = _scriptureReference[0];
            _scriptureReferenceChapter = int.Parse(_scriptureReference[1]);
            _scriptureReferenceVerse = int.Parse(_scriptureReference[2]);
        }
    }

}