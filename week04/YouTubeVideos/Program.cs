using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting to display videos...");
        List <Video> videos = new List<Video>();
        // this is for the first video 
        Video video1 = new("How to code using C#", "Ntech", 300);
        video1.AddComment(new Comment("Ade", "Now I understand this very well!"));
        video1.AddComment(new Comment ("Tegan","this is very helpful!"));
        video1.AddComment(new Comment("Folake","I really love this tutorial it is highly helpful"));
        videos.Add(video1);

        // this is for the second video
        Video video2 = new("Python made easy", "Ntech", 600);
        video2.AddComment(new Comment("Temi", "Never knew python could be fun!"));
        video2.AddComment(new Comment ("Tegan","Finally python doesnt seems to be hard!"));
        video2.AddComment(new Comment("Folake","thanks for making programming easier"));
        videos.Add(video2);

        // this is for the third video
        Video video3 = new("MySQL fundamentals", "Ntech", 250);
        video3.AddComment(new Comment("Grace", "Very helpful, thanks!"));
        video3.AddComment(new Comment ("Rose","this is really breathe taking thanks so much!"));
        video3.AddComment(new Comment("Emmanuel","Amazing content!"));
        videos.Add(video3);

        foreach (var video in videos){
            video.DisplayVideo();
        }
    }
}