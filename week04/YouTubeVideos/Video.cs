using System;
using System.Data;
using System.Net;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private List<Comment> _comments;
    private int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}  ");
        Console.WriteLine($"Author: {_author}  ");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine($"Comment #: {GetNumberOfComments()}  ");
        Console.WriteLine($"Comments: ");
        Console.WriteLine($" ");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"   -   {comment.GetDisplayText()}");

        }

    }

}




