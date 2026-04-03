using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        protected override void PerformActivity()
        {
            Random rnd = new Random();
            string prompt = prompts[rnd.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Console.WriteLine("You have a few seconds to start thinking...");
            ShowCountdown(5);

            int elapsed = 0;
            List<string> entries = new List<string>();
            while (elapsed < Duration)
            {
                Console.Write("Enter item (or press Enter to finish): ");
                string entry = Console.ReadLine();
                if (!string.IsNullOrEmpty(entry))
                    entries.Add(entry);

                elapsed += 2;
            }

            Console.WriteLine($"You listed {entries.Count} items.");
        }
    }
}