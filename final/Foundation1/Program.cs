using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Videos & Comments
        // Hopefully "User1", etc., is an okay name for the commenters. I had a bit of a hard time coming up with all of the Authors, Titles, and Comments, and I ran out of ideas.
        // Some users comment more that once. This is intentional, to more accurately replicate commenting on videos. If this is a problem, ket me know, and I can quickely fix it.
        Video video1 = new Video("10 Life Hacks You Need to Try ASAP", "LifeHacksHQ", 360);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot from this.");
        video1.AddComment("User3", "Can't believe I've been sleeping on this.");
        videos.Add(video1);

        Video video2 = new Video("Behind the Scenes: Making of a Blockbuster Movie", "GamerGalaxy", 4500);
        video2.AddComment("User3", "Nice content!");
        video2.AddComment("User2", "Watching this at 3 AM, who needs sleep anyway?");
        video2.AddComment("User4", "I can't believe how talented this creator is!");
        videos.Add(video2);

        Video video3 = new Video("Meditation Techniques for Stress Relaxation", "MindfulMoments", 660);
        video3.AddComment("User1", "This was helpful.");
        video3.AddComment("User5", "Could you make more videos like this?");
        video3.AddComment("User6", "Who's still watching in 2024?");
        video3.AddComment("User2", "Anyone else binge-watching these videos?");
        videos.Add(video3);

        Video video4 = new Video("Epic Pranks Compilation: Laugh Till You Cry", "ComedyCraze", 2100);
        video4.AddComment("User2", "I'm supposed to be studying, but here I am");
        video4.AddComment("User4", "This deserves way more views, underrated masterpiece.");
        video4.AddComment("User6", "I can't stop replaying this, send help!");
        video4.AddComment("User7", "The comments section is the best part of YouTube!");
        videos.Add(video4);

        // Iterate through the list
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            // Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}