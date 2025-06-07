using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Welcome to the Mindfulness program");


        int ch = 0;
        do
        {
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            ch = int.Parse(choice);

            if (ch == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.StartingMessage();
                breathing.GetTime();
                Thread.Sleep(1000);

                breathing.ShowSpinner(4);

                breathing.ShowDots();
                Console.WriteLine();

                breathing.Run();
                Thread.Sleep(500);
                breathing.ShowSpinner(4);
                Thread.Sleep(500);
                breathing.EndingMessage();
            }
            else if (ch == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.StartingMessage();
                reflecting.GetTime();
                Thread.Sleep(1000);

                reflecting.ShowSpinner(4);

                reflecting.ShowDots();
                Console.WriteLine();

                reflecting.Run();
                Thread.Sleep(500);
                reflecting.ShowSpinner(4);
                Thread.Sleep(500);
                reflecting.EndingMessage();
            }
            else if (ch == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.StartingMessage();
                listing.GetTime();
                Thread.Sleep(1000);

                listing.ShowSpinner(4);

                listing.ShowDots();
                Console.WriteLine();

                listing.Run();
                Thread.Sleep(500);
                listing.ShowSpinner(4);
                Thread.Sleep(500);
                listing.EndingMessage();
            }
        } while (ch != 4);
    }
}