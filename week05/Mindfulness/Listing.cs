using System;
using System.Collections.Generic;

public class ListingActivity:Activity

{
private List<string> _prompts;
private List<string> _items;


    public ListingActivity()
        :base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        _items = new List<string>();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_items.Count} items.");

        EndActivity();
    }
}