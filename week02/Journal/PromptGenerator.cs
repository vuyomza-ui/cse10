using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "What did you learn today?",
        "What are you grateful for today?",
        "What is one thing you want to improve on tomorrow?",
        "Who was the most interesting person I interacted with today?",
        "What was the strongest emotion I felt today?",
    };

    public string GetRandomPrompt()
    {
        // Get a random prompt from the list of prompts
        Random random = new Random();
        int index = random.Next(prompts.Count);

        return prompts[index];
    } 
}