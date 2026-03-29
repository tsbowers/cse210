using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("How to Train a Goldfish", "AquaMaster1299", 320);
        Video v2 = new Video("DIY Rocket Boots", "ScienceTerraria", 540);
        Video v3 = new Video("The History of Sandwiches", "FoodLore", 410);

        v1.AddComment(new Comment("Mia", "My goldfish has a higher net worth than me."));
        v1.AddComment(new Comment("Tom", "Mine just stares at me disapprovingly."));
        v1.AddComment(new Comment("Luna", "This video changed my life. And my fish's."));

        v2.AddComment(new Comment("Evan", "Tried this. Now my shoes are missing."));
        v2.AddComment(new Comment("Rita", "My lawyer says I shouldn't attempt this again."));
        v2.AddComment(new Comment("Sammy", "Best video ever!"));

        v3.AddComment(new Comment("Oliver", "I never want to eat a sandwich again."));
        v3.AddComment(new Comment("Zoe", "This is deeper than most documentaries."));
        v3.AddComment(new Comment("Ben", "Did… did I just watch a sandwich timeline?"));

        List<Video> videos = new List<Video>() { v1, v2, v3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"  {c._name}: {c._text}");
            }

            Console.WriteLine(); 
        }
    }
}