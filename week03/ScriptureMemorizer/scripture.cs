using System.Runtime.CompilerServices;

public class Scripture
{

    private string _scriptureReference = "Galacians 2:20";

    public string GetScriptureReference()
    {
        return _scriptureReference;
    }

    public List<Words> _scriptureList = new List<Words>();
    private string _currentScripture = "I am crucified with Christ: nevertheless I live; yet not I, but Christ liveth in me: and the life which I now live in the flesh I live by the faith of the Son of God, who loved me, and gave himself for me.";




    public Scripture()
    {
        AddScripturetoList(_currentScripture);
    }

    private void AddScripturetoList(string _scripture)
    {
        foreach (string word in _scripture.Split(' '))
        {
            _scriptureList.Add(new Words(word));
        }

    }

    public int DisplayWords()
    {
        Console.Clear();

        Console.WriteLine(GetScriptureReference());

        int unHiddenCount = 0;
        foreach (Words word in _scriptureList)
        {
            if (word.IsHidden)
            {
                Console.Write(new string('-', word.Text.Length) + " ");
            }
            else
            {
                Console.Write(word.Text + " ");
                unHiddenCount++;
            }
        }

        Console.WriteLine();
        return unHiddenCount;
    }


    public string get_currentScripture;


};