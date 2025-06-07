using System;
using System.Collections.Generic;
using System.ComponentModel;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {

        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _name = "Reflecting activity";
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _prompts = new List<string>();
        _questions = new List<string>();

        string prompt1 = "Think of a time when you stood up for someone else.";
        string prompt2 = "Think of a time when you did something really difficult.";
        string prompt3 = "Think of a time when you helped someone in need.";
        string prompt4 = "Think of a time when you helped someone in need.";

        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);

        string question1 = "Why was this experience meaningful to you?";
        string question2 = "Have you ever done anything like this before?";
        string question3 = "How did you get started?";
        string question4 = "How did you feel when it was complete?";
        string question5 = "What made this time different than other times when you were not as successful?";
        string question6 = "What is your favorite thing about this experience?";
        string question7 = "What could you learn from this experience that applies to other situations?";
        string question8 = "What did you learn about yourself through this experience?";
        string question9 = "How can you keep this experience in mind in the future?";


        _questions.Add(question1);
        _questions.Add(question2);
        _questions.Add(question3);
        _questions.Add(question4);
        _questions.Add(question5);
        _questions.Add(question6);
        _questions.Add(question7);
        _questions.Add(question8);
        _questions.Add(question9);

        
        Random random = new Random();
        int ranp = random.Next(0, 4);
        

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--{_prompts[ranp]}--");
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Thread.Sleep(2000);
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.Write("You begin in: ");
        Thread.Sleep(600);
        ShowCountdown(5);


        while (DateTime.Now < endTime)

        {
            Random randomq = new Random();
            int ranq = randomq.Next(0, 9);

            Console.WriteLine(_questions[ranq]);
            ShowSpinner(7);
            Console.WriteLine();
        }
        Console.WriteLine();


    }
}