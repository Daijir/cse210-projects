using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("My life summery of 2024!", "This is me :D", 210);
        video1.AddComment(new Comment("Griffin", "Greate video I've ever seen in 2024!"));
        video1.AddComment(new Comment("Mark", "This is actually nice."));
        video1.AddComment(new Comment("Lucy", "Greate one"));

        Video video2 = new Video("Theory of Relativity in 3 min!", "One Scientist Said,", 180);
        video2.AddComment(new Comment("Paul", "It's still confusing but kinda make sense"));
        video2.AddComment(new Comment("Luser", "This explanation is quite understandable! Thx!!!"));

        Video video3 = new Video("Vlog recap of 2024", "My life is beautiful", 240);
        video3.AddComment(new Comment("gg", "Best vlog in 2024!"));
        video3.AddComment(new Comment("qq", "Looks so interesting."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display Information for each video
        foreach (var video in videos)
        {
            video.DisplayInformation();
        }
    }
}