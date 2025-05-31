using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        

        string wholeText = "Are there any among the vanities of the Gentiles that can cause rain? or can the heavens give showers? art not thou he, O Lord our God? therefore we will wait upon thee: for thou hast made all these things.";
        string wholeText2 = "But the Lord said unto Samuel, Look not on his countenance, or on the height of his stature; because I have refused him: for the Lord seeth not as man seeth; for man looketh on the outward appearance, but the Lord looketh on the heart.";
        string book = "Jer";
        int chapter = 14;
        int verse = 22;
        string book1 = "Psalms";
        int chapter1 = 139;
        int startVerse1 = 7;
        int endVerse1 = 10;
        Reference reference = new Reference(book, chapter, verse);
        Reference reference1 = new Reference(book1, chapter1, startVerse1, endVerse1);
        Scripture scripture1 = new Scripture(reference, wholeText);
        Scripture scripture2 = new Scripture(reference1, wholeText2);
        Random randomI = new Random();
        int s1 = scripture1.GetList().Count();
        int s2 = scripture2.GetList().Count();
        int z;

        
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Press Enter to display options");
        Console.ReadLine();
        
        
        
        Console.WriteLine("Choose 1 versed or multiple versed scripture by typing 1 or 2");
    
        string userInput = Console.ReadLine();
        int scr = int.Parse(userInput);
        
        // waits for the user to press a key
        

        if (scr == 1)

        {
            z = 1;
            Console.WriteLine($"{reference.GetDisplayReference()} {scripture1.GetDisplayText1()}");
           
            if (userInput != "quit")
            {
                 ConsoleKeyInfo keyInput = Console.ReadKey(true);
                do
                {
                    int numberToHide = randomI.Next(1, s1);

                    if (keyInput.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        scripture1.HideRandomWords(numberToHide);
                        Console.ReadLine();
                    }

                } while (scripture1.IsCompletelyHidden() == false);
                Console.WriteLine("You memorized the whole scripture. Well done!");
            }
        }
        else if (scr == 2)

        {
            z = 2;
            Console.WriteLine(scripture1.GetDisplayText1());
            if (userInput != "quit")
            {
                ConsoleKeyInfo keyInput = Console.ReadKey(true);
                do
                {
                    int numberToHide = randomI.Next(1, s2);

                    if (keyInput.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        scripture2.HideRandomWords(numberToHide);
                        Console.ReadLine();
                    }

                } while (scripture2.IsCompletelyHidden() == false);
                Console.WriteLine("You memorized the whole scripture. Well done!");
            }
        }
    }
     }

 