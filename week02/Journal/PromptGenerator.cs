using System.IO;
using System.Collections.Generic;

public class PromptGenerator

{
    List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomI = new Random();
        int i = randomI.Next(_prompts.Count);

        string filename = "Prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("&");

            _prompts.AddRange(parts);
        }
        return _prompts[i];
    }
}