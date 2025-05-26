using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{

    private List<Word> _words;
    Reference _reference;


    // constructor
    public Scripture(Reference reference,string wholeText)
    {
        _reference=reference;
        _words = new List<Word>();
        string[] wordsArray = wholeText.Split(" ");

        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }
    public List<Word> GetList()
    {
        return _words;
    }
    public string GetDisplayText()
    {
    
        string fullText = string.Join(" ", _words);
        return _reference.GetDisplayReference() + " " + fullText;
    }

    public void HideRandomWords(int numberToHide)
    {
        
        if (_words[numberToHide].IsHidden()==false)
        {
            _words[numberToHide].Hide();
            Console.WriteLine(GetDisplayText());
        }
        else
        {   
            Random randomF = new Random();
            int rf = _words.Count();
            int numberToHidef=randomF.Next(1,rf);

            if (_words[numberToHidef].IsHidden()==false)
            {
                _words[numberToHidef].Hide();
                Console.WriteLine(GetDisplayText());
            }
            
        }
    }

public bool IsCompletelyHidden()
{
    foreach (Word w in _words)
    {
        if (!w.IsHidden())
        {
            return false;
        }
    }
    return true;
}

}


