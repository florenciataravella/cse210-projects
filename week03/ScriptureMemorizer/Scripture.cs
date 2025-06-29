using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Scripture
{
    // declaration of private list of data tye "words"
    private List<Word> _words;
    Reference _reference;


    // constructor
    public Scripture(Reference reference,string wholeText)
    {
        _reference=reference;
        // creation of the object list that the scripture 
        // constructor needs to access the words
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
    public string GetDisplayText1()
    {
    
        string fullText = string.Join(" ", _words);
        return _reference.GetDisplayReference() + " " + fullText;
    }
    public string GetDisplayText2()
    {
    
        string fullText = string.Join(" ", _words);
        return _reference.GetDisplayRangedReference() + " " + fullText;
    }

    public void HideRandomWords(int numberToHide, int z)
    {
        if (z == 1)
        {
            do
            {
                _words[numberToHide].Hide();
                Console.WriteLine(_reference.GetDisplayReference());
            } while (_words[numberToHide].IsHidden() == false);
        }
        else
           {
            do
            {
                _words[numberToHide].Hide();
                Console.WriteLine(_reference.GetDisplayRangedReference());
            } while (_words[numberToHide].IsHidden() == false);
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


