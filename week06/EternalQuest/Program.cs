using System
""" 
author - Trevor Bowers
Purpose - Eternal Quest
"""
class Program
{
    static void Main()
    {
        GoalManager gm = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n1. Add Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1.Simple 2.Eternal 3.Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    gm.AddGoal(new SimpleGoal(name, desc, points));

                else if (type == "2")
                    gm.AddGoal(new EternalGoal(name, desc, points));

                else if (type == "3")
                {
                    Console.Write("Target: ");
                    int target = int.Parse(Console.ReadLine());

                    gm.AddGoal(new ChecklistGoal(name, desc, points, target));
                }
            }
            else if (choice == "2")
            {
                gm.ShowGoals();
            }
            else if (choice == "3")
            {
                gm.ShowGoals();
                Console.Write("Which goal? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                gm.RecordGoal(index);
            }
            else if (choice == "4")
            {
                gm.ShowScore();
            }
            else if (choice == "5")
            {
                gm.Save("goals.txt");
            }
            else if (choice == "6")
            {
                gm.Load("goals.txt");
            }
            else if (choice == "7")
            {
                break;
            }
        }
    }
}