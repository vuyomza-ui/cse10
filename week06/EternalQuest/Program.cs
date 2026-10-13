using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _score = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "8")
        {
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("          Eternal Quest Program");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. List Goals");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");

            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateSimpleGoal();
                    break;

                case "2":
                    CreateEternalGoal();
                    break;

                case "3":
                    CreateChecklistGoal();
                    break;

                case "4":
                    RecordEvent();
                    break;

                case "5":
                    ListGoals();
                    break;

                case "6":
                    SaveGoals();
                    break;

                case "7":
                    LoadGoals();
                    break;

                case "8":
                    Console.WriteLine("Thank you for playing Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-8.");
                    break;
            }
        }
    }
    
    static void CreateSimpleGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Creating a Simple Goal");

        Console.Write("What is the name of your goals? ");
        string name = Console.ReadLine();

        Console.Write("What is a short decription of it? ");
        string description = Console.ReadLine();

        int points = GetNumber(
            "Write is the amount of points associated with this goal? ");
                
        Goal goal = new SimpleGoal(
        name,
        description,
        points);

        _goals.Add(goal);

        Console.WriteLine(
            "Simple goal created successfully!");
    }

    static void CreateEternalGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Creating an Eternal Goal");

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        int points = GetNumber(
            "What is the amount of points assoiciated with this goal? ");

        Goal goal = new EternalGoal(
        name,
        description, 
        points);

        _goals.Add(goal);

        Console.WriteLine(
            "Eternal gaol created successfull!");
    }

    static void CreateChecklistGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Creating a checklist Goal");

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        int points = GetNumber(
            "What is the amount of points associated with this goal?");

        int target = GetNumber(
            "How many times does this goal need to be completed? ");

        int bonus = GetNumber(
            "What is the bonus for completing the goal? ");

        Goal goal = new ChecklistGoal(
            name,
            description,
            points,
            target,
            bonus
        );

        _goals.Add(goal);

        Console.WriteLine(
            "Checklist goal created successfully!");
    }

    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine(
                "You don't have any goals yet.");

            return;
        }

        Console.WriteLine();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int goalNumber = GetNumber(
            "Which goal did you accomplish? ");

        if (goalNumber < 1 || 
            goalNumber > _goals.Count)
        {
            Console.WriteLine(
                "Invalid goal number.");

            return;
        }

        Goal selectedGoal = _goals[goalNumber - 1];

        int pointsEarned = selectedGoal.RecordEvent();

        _score += pointsEarned;

        Console.WriteLine(
            $"You earned {pointsEarned} points!");
        Console.WriteLine(
            $"Your new score is {_score} points.");

        CheckForLevelUp();
    }

    static void ListGoals()
    {
        Console.WriteLine();
        Console.WriteLine("Your Goals:");

        if (_goals.Count == 0 )
        {
            Console.WriteLine(
                "You don't have any goals yet.");

            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals [i].GetDetailsString()}");
        }
    }

    static void SaveGoals()
    {
        Console.WriteLine();
        Console.WriteLine("Enter the filename to save to:");

        string filename = Console.ReadLine();

        using (StreamWriter outputFile =
               new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(
                    goal.GetStringRepresentation());
            }
        }

        Console.WriteLine(
            "Goals saved successfully!");
    }

    static void LoadGoals()
    {
        Console.WriteLine();
        Console.Write("Enter the filename to load: ");

        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                _goals.Add(
                    new SimpleGoal(
                        name,
                        description,
                        points,
                        complete));
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                _goals.Add(
                    new EternalGoal(
                        name,
                        description,
                        points
                    )
                );
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name =  parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                _goals.Add(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus,
                        completed));
            }
        }

        Console.WriteLine(
            "Goals loaded successfully!");
    }

    static int GetNumber(string message)
    {
        while (true)
        {
            Console.Write(message);

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine(
                "Please enter a valid number.");
        }
    }

    static void CheckForLevelUp()
    {
        int level = (_score / 1000) + 1;

        if (_score > 0 && _score % 1000 == 0)
        {
            Console.WriteLine();
            Console.WriteLine(
                "*******************************************");
            Console.WriteLine(
                $"        LEVEL UP! You are now");
            Console.WriteLine($"             LEVEL {level}!");
            Console.WriteLine(
                "*******************************************");
        }
    }

    // Creativity / Exceeding requirements:


    // I added a level up system that notifies the player when they reach a new level based on their score.
    // The user earns a new level for every 1,00 points earned.
    // The program celebrates the user when they reacha new level.

    // I also added input validation so the program does not crash when the user enter somthing other than a number.

}