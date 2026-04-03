using System;
using System.Threading;

namespace MindfulnessProgram
{
    abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"--- {_name} ---");
            Console.WriteLine(_description);
            Console.Write("Enter duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Get ready...");
            ShowCountdown(3);

            PerformActivity();
            Finish();
        }

        protected abstract void PerformActivity();

        private void Finish()
        {
            Console.WriteLine("\nWell done!");
            ShowCountdown(3);
            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.\n");
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\r ");
            }
            Console.WriteLine();
        }

        protected void Spinner(int duration)
        {
            string[] spinner = { "|", "/", "-", "\\" };
            for (int i = 0; i < duration; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(500);
                Console.Write("\b");
            }
        }

        protected int Duration => _duration;
    }
}