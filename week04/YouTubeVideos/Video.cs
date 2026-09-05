using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Constructor
    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Adds a comments to the video.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Returns the number of comments.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Displays the video information and comments.
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetDisplayText()}");
        }

        Console.WriteLine();
    }
}