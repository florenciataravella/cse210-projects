using System;
using System.Collections.Generic;

public class Assignment
{
    private string _name = "";
    private string _topic="";

    public Assignment(string name, string topic)

    {
        _name = name;
        _topic = topic;

    }
    public string GetName(string name)
    {
        return _name;
    }
    public string GetTopic(string topic)
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{ _name}, { _topic}";
    }
}