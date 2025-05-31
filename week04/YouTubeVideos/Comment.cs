using System;
using System.Collections.Generic;

public class Comment
{
    private string _nameCommenter;
    private string _textComment;

    // constructor
    public Comment(string nameCommenter, string textComment)

    {
        _nameCommenter = nameCommenter;
        _textComment = textComment;

    }

    public string GetDisplayComment()
    {
        return _nameCommenter + ": " + _textComment;
    }
    
}

