using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName=PromptUserName();
        int userSquare=SquareNumber();
        DisplayResult(userName,userSquare);
    }
static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the program!");
}
static string PromptUserName()
{
    Console.WriteLine("What is your name?");
    string userName=Console.ReadLine();
    return userName;
}
static int PromptUserNumber()
{
    Console.WriteLine("What is your favorite number?");
    string userInput=Console.ReadLine();
    int number=int.Parse(userInput);
    return number;
}
static int SquareNumber()
{
    int number=PromptUserNumber();
    int result=number*number;
    return result;
}
static void DisplayResult(string userName, int userSquare)
{
    Console.WriteLine($"{userName}, the square of your number is {userSquare}");
}
}