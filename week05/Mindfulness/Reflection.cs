using System;
using System.Collections.Generic;

public class ReflectionActivity:Activity

{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
        :base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ")

    
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone.",
            "Think of a time when you overcame a challenge."
        };
    

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        EndActivity();
    }
}