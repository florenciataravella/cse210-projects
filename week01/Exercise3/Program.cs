using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
    
        string userGuess;
        int guess;
    do 
        {
        Console.WriteLine("What is your guess?");
        userGuess=Console.ReadLine();
        guess=int.Parse(userGuess);
                
            if (magicNumber>guess)
            {
            Console.WriteLine("greater");
            }
            else if (magicNumber==guess)
            {
            Console.WriteLine("You guessed!");
            }
            else
            {
            Console.WriteLine("lower");
            }
        } while (magicNumber!=guess);
    
        
    }
    
}