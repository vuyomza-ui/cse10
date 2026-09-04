using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Program");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();
                
                Entry entry = new Entry(date, prompt, response);

                journal.AddEntry(entry);

                Console.WriteLine("Entry added! ");    
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the Filename; ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded!");
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("GoodBye!");
            }
            else
            {    
                Console.WriteLine("Invalid option. please choose 1-5.");
            }
        }
    }
}
