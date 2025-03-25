using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

public class Video
{

    private string _title = "";
    private string _author = "";
    private double _length = 0;

    private List<Comment> _commentList = new List<Comment>();

    public void AddComment(string CommentNameandComment)
    {
        int colonIndex = CommentNameandComment.IndexOf(":");

        string name = CommentNameandComment.Substring(0, colonIndex);
        string comment = CommentNameandComment.Substring(colonIndex + 1).Trim();
        
        Comment newComment = new Comment(name, comment);


        _commentList.Add(newComment);
    }

    public List<Comment> GetComments()
    {
        return _commentList;
    }



    private void Title(string videoTitle)
    {
        _title = videoTitle;
    }

    public void SetTitle(string videoTitle)
    {
        Title(videoTitle);
    }

    public string GetTitle()
    {
        return _title;
    }

    private void Author(string videoAuthor)
    {
        _author = videoAuthor;
    }

    public void SetAuthor(string videoAuthor)
    {
        Author(videoAuthor);
    }
    public string GetAuthor()
    {
        return _author;
    }

    private void Length(double videoLength)
    {
        _length = videoLength;
    }

    public void SetLength(double videoLength)
    {
        Length(videoLength);
    }
    public double GetLength()
    {
        return _length;
    }
}