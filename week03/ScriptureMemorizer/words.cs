using Microsoft.VisualBasic;

public class Words
{
    public string Text { get; private set; }

    public bool IsHidden { get; private set; }

    public void Hide()
    {
        IsHidden = true;
    }







    public Words(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public override string ToString()
    {
        return Text;
    }

}