using System;
using System.IO;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "Jer";
        _chapter = 14;
        _verse = 22;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayReference()
    {
        return _book + "" + _chapter + ":" + _verse;

    }
    public string GetDisplayRangedReference()
    {
        return _book + _chapter + ":" + _startVerse + _endVerse;
    }


}
