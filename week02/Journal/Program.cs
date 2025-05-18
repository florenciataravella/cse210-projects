using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello World! This is the Journal Project.");


        Journal myJournal = new Journal();
        PromptGenerator pPrompt = new PromptGenerator();
        DateTime journalDay = DateTime.Now;
        int answer = 0;
        


        do
        {

            Console.WriteLine("What do you want to do?:");
            Console.WriteLine("1: Write");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Load");
            Console.WriteLine("4: Save");
            Console.WriteLine("5: Quit");

            string input = Console.ReadLine();
            answer = int.Parse(input);




            if (answer == 1)
            {
                string prompt = pPrompt.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Entry e = new Entry();

                e._entryText = Console.ReadLine();
                e.time();
                e._promptText = prompt;
                myJournal.AddEntry(e);


            }
            if (answer == 2)
            {
                myJournal.DisplayAll();

            }
            if (answer == 3)
            {
                Console.WriteLine("What is the name of the file?:");
                string loadfile = Console.ReadLine();
                myJournal.LoadFromFile(loadfile);

            }
            if (answer == 4)
            {
                Console.WriteLine("Where would you like to save the file?");
                string saveFile = Console.ReadLine();
                myJournal.SaveToFile(saveFile);


            }


            if (answer == 5)
            {
                Console.WriteLine("Closing the journal app");

            }
        }
        while (answer != 5);
}
        }