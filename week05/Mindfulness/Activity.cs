using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

public class Activity
{

    protected string _description;
    protected int _duration;
    protected string _name;


    public Activity()
    {
        _duration = 12;
        _name = "";
        _description = "";
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    // public void SetTime(int time)
    // {
    //     _duration = time;
    // }
    public int GetTime()
    {
        string time = Console.ReadLine();
        _duration = int.Parse(time);
        return _duration;
    }
    public void StartingMessage()
    {
        string startingMessage = $"This is the {_name}.{_description} How long in seconds would you like this activity to last?";
        Console.WriteLine(startingMessage);
    }
    public void EndingMessage()
    {
        string endingMessage = $"Well done!! \nYou have completed another {_duration} seconds of the {_name}";
        Console.WriteLine(endingMessage);
    }

    public void ShowCountdown(int sec)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);
        while (DateTime.Now < endTime)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }

    }
    public void ShowSpinner(int sec)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count())
            {
                i = 0;
            }
        }

    }
    public void ShowDots()
    {
        Console.Write("Get ready ");
        Thread.Sleep(1000);
        for (int i = 0; i < 4; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

}