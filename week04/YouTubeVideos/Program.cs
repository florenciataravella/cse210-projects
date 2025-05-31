using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        string title = "Biology of human body";
        string author = "Arthur Waltman";
        double length = 384;
        string commNameC = "Edward Brick";
        string commTextC = "Would like to see more about the subject";
        Comment commentA = new Comment("Maria", "I liked the video, but I think should be more descriptive");
        Comment commentB = new Comment("Juan", "It was very interesting");
        Comment commentC = new Comment(commNameC, commTextC);
        Video video1 = new Video(title, author, length);
        video1.AddComment(commentA);
        video1.AddComment(commentB);
        video1.AddComment(commentC);

        video1.DisplayVideo();

        string titleA = "String Theory for begginers";
        string authorA = "John Whitman";
        double lengthA = 521;
        Comment commentAA = new Comment("Florencia", "Nice and graphically explained");
        Comment commentAB = new Comment("Ricardo", "Well structured, however little explanation of gravity force influece in relativism");
        Comment commentAC = new Comment("Marcos", "I liked very much, I would like to see more on the subject");
        Video video2 = new Video(titleA, authorA, lengthA);
        video2.AddComment(commentAA);
        video2.AddComment(commentAB);
        video2.AddComment(commentAC);

        video2.DisplayVideo();

        Comment commentAAA = new Comment("Catherine", "I foud the topic very useful, thank you!");
        Comment commentAAB = new Comment("Jessy", "I didn't know AI could be so easy to use");
        Comment commentAAC = new Comment("Patricia", "I would like to try this and see if I can replicate");
        Video video3 = new Video("Using AI for IG posts", "Steve Arnolds", 421);
        video3.AddComment(commentAAA);
        video3.AddComment(commentAAB);
        video3.AddComment(commentAAC);

        video3.DisplayVideo();
        
    }
}