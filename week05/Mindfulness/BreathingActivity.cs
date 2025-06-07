using System;
using System.Collections.Generic;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    
    public BreathingActivity() : base()
    {
        
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _name = "Breathing activity";
    }

    public void Run()
    {

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");

            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine();
            Console.Write("Now breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine();

        }
        Console.Clear();
        
        
    }
  
}