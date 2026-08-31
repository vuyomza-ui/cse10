using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.Write("What is your first name? ");
        string name = Console.Readline();
        
        
        Console.Write("What is your last name? ");
        string lastname = Console.Readline();

        Console.WriteLine($"Your name is {name}, {name} {lastname}.");
    }
}