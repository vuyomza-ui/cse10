using System;

class Program
{
    // The Main method is the program starts running 
    static void Main(string[] args)
    {
        // Calls the DisplayMessage method
        DisplayMessage();
        
        Console.WriteLine($"Please enter your name: ");
        string userName = Console.ReadLine();
        
        // Calls the DisplayPersonalMessage method and passes the user's name 
        DisplayPersonalMessage(userName);
        
        Console.Writeline("Please eneter your favourite number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"UserName}, the square of your number is {SquareNumber(number)}");
        }
        
        // This method displays a welcome message
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program");

        }

        static void DisplaypersonalMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }

        // This method Calculates the square of a number
        static int SquareNumber(int number)
        {
            return number * number;
        
    }
}