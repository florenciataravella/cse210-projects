using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Florencia Taravella", "Review");
        MathAssignment mathAssignment = new MathAssignment("Florencia Taravella", "Fractions", "7.13", "7-13");
        // Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

    }
}