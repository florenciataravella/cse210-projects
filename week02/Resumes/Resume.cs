
using System.Collections.Generic;
public class Resume
{
    public string _name;
    public List<Job> _jobList=new List<Job>();

    public void DisplayResume()

    {
        Console.WriteLine($"Name: ");
        Console.WriteLine(_name);
        foreach (Job j in _jobList)
    {
        j.DisplayJobs();

    }
    }
}