using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public DateTime _nowDate = DateTime.Now;
    
    public string _promptText;
    public string _entryText;

    public string time()
    {
         return _nowDate.ToShortDateString();
    }
    public void Display()
    {
        
        string display = time() + " " + "-" + _promptText + Environment.NewLine + _entryText;
        Console.WriteLine(display);
    }

 }