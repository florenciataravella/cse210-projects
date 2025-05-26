using System;
using System.IO;
using System.Collections.Generic;

public class Word
{
    private string _text;
    private bool _IsHidden;

    // constructor 
    public Word(string text)
    {
        _text = text;
        _IsHidden = false;
    }

    public void Hide()
    {
        _text = "____";
        _IsHidden = true;
    }
    public void Show(string text)
    {
        _IsHidden = false;
    }

    public bool IsHidden()
    {
        
        if (_text == "____")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        return _text;
    }
    public override string ToString()
    {
        return GetDisplayText();
    }
}