using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> Videos = new List<Video>();

        Video video1 = new Video ("How to build a snow man", "Brown Jacob", 430);
        video1.AddComment(new Comment("Paul", "A very informative video!"));
        video1.AddComment(new Comment("John", "Wow! Very interesting!"));
        video1.AddComment(new Comment("Anne", "Thank you for sharing!"));
        Videos.Add(video1);

        Video video2 = new Video ("How to grow your business", "Michael Joe", 670);
        video2.AddComment(new Comment("Peace", "A good watch!"));
        video2.AddComment(new Comment("Meg", "This very concise"));
        video2.AddComment(new Comment("Effiong", "Accurate!"));
        video2.AddComment(new Comment("Edet", "Impressive!"));
        Videos.Add(video2);

        Video video3 = new Video ("Nigeria in 10 Minutes", "Lawrence Itam", 600);
        video3.AddComment(new Comment("Smith", "This cleared my doubts"));
        video3.AddComment(new Comment("Mark", "Nigeria is truly a beautiful country"));
        video3.AddComment(new Comment("Uche", "I miss home"));
        Videos.Add(video3);        

        foreach (Video video in Videos)
        {
            Console.WriteLine("\n||| Video Info |||");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Comments ({video.GetCommentCount()})");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"■ {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}