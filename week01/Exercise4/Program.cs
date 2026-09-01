using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //Create the list
        //Ask for a number until  they enter 0 
        //Loop list until they give the number 0
        
        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished.");

        int number = 1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        
        }
        
        //Calculate the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum+= num;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        //Calculate the average

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");
        //Find the Largest number
        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;

            }
        }
        
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        //Sort te list        
        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);

        }
    }
}