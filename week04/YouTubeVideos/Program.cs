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
        }

    }
}


/*
notes to remember and think about
classes
video    for the video info
comments class  for the comments on videos  name and what they say    so like _name and _text or _comment    and a way to display the comment
in video class  store video details, list of comments and # of comments (total)   so the data needed woyuld be _title _author  _length _comments 
    need to be able to add comment to the list and increase the # of comments.  and display comments 
mains responsibility is to control the program, manage the overall collection.  comments is a sub of a video so its in the vido class.  
have to ask does this belong to the subject or the program ..  something to remember.  


still doesn't add the comments.  


*/




