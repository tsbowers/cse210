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
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");  

            Console.WriteLine("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                running = false;
            }
            else if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                entry._prompt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.saveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.loadFromFile(filename);
            }
        }
    }
}