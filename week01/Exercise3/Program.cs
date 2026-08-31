using System;

class Program
{
    static void Main(string[] args)
        //RandomGenerator#1
        //While loop#2
        //If stantment 

    {
       
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;
        while (guess != magicnumber)
        {
            Console.WriteLine("What is the Magic number? ");
            Guess = int.Parse(console.ReadLine());

            if (magicnumber > guess)
            {
                console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("you guessed it!");
            }

        }

    }

    
}