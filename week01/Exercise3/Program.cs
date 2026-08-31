using System;

class Program
{
    static void Main(string[] args)
        

    {
       //RandomGenerator#1
        //While loop#2
        //If stantment

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        while (guess != magicNumber)
        {
            Console.WriteLine("What is the Magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("you guessed it!");
            }

        }

    }

    
}