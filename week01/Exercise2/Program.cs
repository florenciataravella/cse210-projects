using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?");
        string userInput=Console.ReadLine();
        int gradePercentage=int.Parse(userInput);

        string letter;

        if (gradePercentage>=90)
        {
            letter="A";
        }
        else if (gradePercentage>=80 && gradePercentage<90)
        {
            letter="B";
        }
        else if (gradePercentage>=70 && gradePercentage<80)
        {
            letter="C";
        }
        else if (gradePercentage>=60 && gradePercentage<70)
        { 
            letter="D";
        }
        else
        {
            letter="F";
        }
        Console.WriteLine($"You have a {letter}");

        if (letter=="A" || letter=="C"|| letter=="B")
        {
            Console.WriteLine("Congratulations, you passed");
        }
        else
        {
            Console.WriteLine("You will do better next time");
        }

    }

}