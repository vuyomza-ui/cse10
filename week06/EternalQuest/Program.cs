using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eternal Quest");

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Quit");

            Console.Write("choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Creating a simple Goal...");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Creating an Eternal Goal...");
            }  
            else if (choice == "3")
            {
                Console.WriteLine("Creating a checkList Goal...");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Recording an event...");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            } 
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}