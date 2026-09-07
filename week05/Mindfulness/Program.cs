using System;

public class Program
{
static void Main(string[] args)

{
while(true)
{
Console.Clear();



            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
            }
}
}
}