using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Selection: ");
                string choice = Console.ReadLine();

                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => null
                };

                if (activity != null)
                    activity.Start();
                else if (choice == "4")
                    running = false;
                else
                    Console.WriteLine("Invalid choice. Try again.");

                Console.WriteLine();
            }
        }
    }
}