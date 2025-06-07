using System;
using System.Collections.Generic;
using System.ComponentModel;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    

    public ListingActivity() : base()
    {

        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _name = "Listing activity";
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _prompts = new List<string>();
        List<string> _items = new List<string>();

        string prompt1 = "Who are people that you appreciate?";
        string prompt2 = "What are personal strengths of yours?";
        string prompt3 = "Who are people that you have helped this week?";
        string prompt4 = "When have you felt the Holy Ghost this month?";
        string prompt5 = "Who are some of your personal heroes?";


        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);

        Random random = new Random();
        int ranp = random.Next(0, 5);


        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{_prompts[ranp]}---");
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.Write("You begin in: ");
        Thread.Sleep(600);
        ShowCountdown(5);
        Console.WriteLine();
        int n = 0;
        while (DateTime.Now < endTime)

        {
            Console.Write(">");
            string input = Console.ReadLine();
            _items.Add(input);
            Console.WriteLine();
            n = n + 1;
        }
        Console.WriteLine();
        Console.WriteLine($"You have listed {n} items.");


    }
}