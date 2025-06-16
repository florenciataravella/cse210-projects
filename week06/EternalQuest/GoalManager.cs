using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void ListGoalNames()
    {
        int i = 0;
        foreach (Goal g in _goals)
        {
            i = i + 1;

            Console.WriteLine($"{i}. {g.GetName()}");

        }
    }
        public void ListGoalDetails()
        {
            foreach (Goal g in _goals)
            {

            Console.WriteLine(g.GetDetailsString());
            }
        }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create? The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Chesklist Goal");
        string ty = Console.ReadLine();
        int type = int.Parse(ty);

        if (type == 1)
        {
            Console.WriteLine("What is the name of your Goal?: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?:");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points assigned to this goal?: ");
            string ans3 = Console.ReadLine();
            int points = int.Parse(ans3);
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);

        }
        else if (type == 2)
        {
            Console.WriteLine("What is the name of your Goal?: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?:");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points assigned to this goal?: ");
            string ans3 = Console.ReadLine();
            int points = int.Parse(ans3);
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);

        }
        else if (type == 3)
        {
            Console.WriteLine("What is the name of your Goal?: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?:");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points assigned to this goal?: ");
            string ans3 = Console.ReadLine();
            int points = int.Parse(ans3);
            Console.WriteLine("How many times does this goal need to be accoplished for a bonus?");
            string answerTimes = Console.ReadLine();
            int target = int.Parse(answerTimes);
            Console.WriteLine("What is the bonus for accomplishing this goal?");
            string answerBonus = Console.ReadLine();
            int bonus = int.Parse(answerBonus);
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }


    }

    public void Start()
    {
        int ch = 0;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu");

            string answer = Console.ReadLine();
            ch = int.Parse(answer);

            if (ch == 1)
            {
                CreateGoal();
            }
            if (ch == 2)
            {
                Console.WriteLine("The goals are:");
                ListGoalDetails();
                
            }
            if (ch == 3)
            {
                SaveGoals();
            }
            if (ch == 4)
                {
                    LoadGoals();
                }
            if (ch == 5)
            {
                RecordEvent();
            }
            

        } while (ch != 6);
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file?");
        string filename = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine($"{_score}");
            {
                foreach (Goal g in _goals)
                {
                    outputfile.WriteLine(g.GetStringRepresentation());
                }
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.WriteLine("What is the name of the file?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");
            string typeOfGoal = parts[0];
            string details = parts[1];
            if (typeOfGoal.Contains("SimpleGoal"))
            {
                _goals.Add(CreateSimpleGoal(details));
            }
            if (typeOfGoal.Contains("EternalGoal"))
            {
                _goals.Add(CreateEternalGoal(details));
            }

            if (typeOfGoal.Contains("ChecklistGoal"))
                {
                    _goals.Add(CreateChecklistGoal(details));
                }

        }
    }
    public SimpleGoal CreateSimpleGoal(string details)
    {
        string[] parts = details.Split(",");
        string name = parts[0];
        string description = parts[1];
        string point = parts[2];
        int points = int.Parse(point);

        SimpleGoal simplegoal = new SimpleGoal(name, description, points);

        return simplegoal;
    }
    public ChecklistGoal CreateChecklistGoal(string details)
    {
        string[] parts = details.Split(",");
        string name = parts[0];
        string description = parts[1];
        string point = parts[2];
        int points = int.Parse(point);
        string bon = parts[3];
        int bonus = int.Parse(bon);
        string targ = parts[4];
        int target = int.Parse(targ);

        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points,bonus, target);

        return checklistGoal;
    }
    public EternalGoal CreateEternalGoal(string details)
    {
        string[] parts = details.Split(",");
        string name = parts[0];
        string description = parts[1];
        string point = parts[2];
        int points = int.Parse(point);

        EternalGoal eternalGoal = new EternalGoal(name, description, points);

        return eternalGoal;
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        string answer = Console.ReadLine();
        int ai = int.Parse(answer);
        string filename = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        if (ai >= 1 && ai <= _goals.Count())
        {
            Goal GoalSelected = _goals[ai - 1];
        
        foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split(":");
                string typeOfGoal = parts[0];
                string details = parts[1];

                if (GoalSelected is SimpleGoal)
                {
                    SimpleGoal sg = CreateSimpleGoal(details);
                    sg.RecordEvent();
                    sg.GetStringRepresentation();
                }
                if  (GoalSelected is EternalGoal)
                {
                    EternalGoal eg = CreateEternalGoal(details);
                    eg.RecordEvent();
                    eg.GetStringRepresentation();
                }
                if (GoalSelected is ChecklistGoal)
                {
                    ChecklistGoal chg = CreateChecklistGoal(details);
                    chg.RecordEvent();
                    chg.GetStringRepresentation();
                }
        }

            }

    }
    
}



