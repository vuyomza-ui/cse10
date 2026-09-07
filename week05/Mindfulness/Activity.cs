using System;
using System.Threading;

public class Activity
{
private string _name;
private string _description;
private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine(
            $"You have completed the {_name} Activity for {_duration} seconds.");
        
        ShowSpinner(3);
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}