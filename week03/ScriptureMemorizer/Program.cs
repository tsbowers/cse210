using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Use default scripture (Alma 26:27)");
        Console.WriteLine("2. Enter your own scripture");

        string choice = Console.ReadLine();

        Reference reference;
        string text;

        if (choice == "2")
        {
            Console.Write("Enter book: ");
            string book = Console.ReadLine();

            Console.Write("Enter chapter: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Enter verse: ");
            int verse = int.Parse(Console.ReadLine());

            reference = new Reference(book, chapter, verse);

            Console.Write("Enter scripture text: ");
            text = Console.ReadLine();
        }
        else
        {
            reference = new Reference("Alma", 26, 27);

            text = "Now when our hearts were depressed, and we were about to turn back, behold, the Lord comforted us, and said: Go amongst thy brethren, the Lamanites, and bear with patience thine afflictions, and I will give unto you success.";
        }

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\n Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }
    }
}