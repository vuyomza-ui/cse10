using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write the Grade of the student: ");
        string valuefromuser = Console.ReadLine();

        int x = int.Parse(valuefromuser);
        
        if (x >= 90)
        {
            Console.WriteLine("A");
        }
        else if (x >= 80)    
        {
            Console.WriteLine("B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}