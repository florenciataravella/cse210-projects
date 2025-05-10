using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers=new List<int>();
        
        string inputNumber;
        int number=1;

        while (number!=0)
        {
            
            inputNumber=Console.ReadLine();
            number=int.Parse(inputNumber);
            numbers.Add(number);
        }
        numbers.Remove(0);
        double sum=0;
        double i=0;
        int largest=0;
        double avg=0;

        foreach (int n in numbers)
        {
            
            sum=sum+n;
            i=i+1;
           
            
            
            if (largest<=n)
            {
                largest=n;
            }

        }
        avg=sum/i;
        Console.WriteLine($"The sum of the list is:{sum}");
        Console.WriteLine($"The average of the list is:{avg}");
        Console.WriteLine($"The largest of the list is:{largest}");

    
    }
}