using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Cat Video", "Thomas The Cat", 240);
        video1.AddComment(new Comment("Kallee", "Funny but cute!"));
        video1.AddComment(new Comment("Asia", "dumb cats, good thing they got 9 lives."));
        video1.AddComment(new Comment("John", "Ugh, more cats?"));

        Video video2 = new Video("Space Invaders", "Marvin the Martian", 480);
        video2.AddComment(new Comment("Kirk", "Reminds me of my life"));
        video2.AddComment(new Comment("Chewbacca", "RAWR, RRRWWGG, WRAARGHH"));
        video2.AddComment(new Comment("Ellen", "good show, but the aliens aren't realistic"));

        Video video3 = new Video("Space Flight", "Prince Vultan", 360);
        video3.AddComment(new Comment("Klytus", "Simply Logical"));
        video3.AddComment(new Comment("Gordon", "RUN!"));
        video3.AddComment(new Comment("Kala", "Nice instruction, thanks!"));


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var Video in videos)
        {
            Video.Display();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
        }

    }
}


/*




*/




