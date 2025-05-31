using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    
    private List<Comment> _comments;
    private List<string> _videos;

    // constructor
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();

    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
   
    public void DisplayVideo()
    {
        
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} sec");
        Console.WriteLine($"{_comments.Count()} comments:");

        foreach (Comment c in _comments)
        {

            Console.WriteLine(c.GetDisplayComment());

        }

    }
}