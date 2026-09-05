using System;

public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference(
            "Proverbs",
            3,
            5,
            6
        );

        // Create the scripture.
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him and he shall direct thy paths."
        );

        //Display the complete scripture.
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Continue until all words are hidden.
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit':");

            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "quit")
            {
                break;
            }

            // Hide thre random words.
            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}