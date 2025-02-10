using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
class Video{
    private string title;
    private string author;
    private int lenght;
    private List <Comment> comments;

    public Video(string title, string author, int lenght){
        this.title = title;
        this.author = author;
        this.lenght=lenght;
        this. comments= new List<Comment>();
    }
    public void AddComment(Comment comment){
        comments.Add(comment);
    }
    public int GetCommentCount(){
        return comments.Count;
    }
    public void DisplayVideo(){
        Console.WriteLine($"\nTitle:{title}");
        Console.WriteLine($"Author:{author}");
        Console.WriteLine($"Lenght:{lenght}");
        Console.WriteLine($"Number of Comments:{GetCommentCount}");

        foreach(var comment in comments){
            comment.DisplayComment();
        }
    }
}