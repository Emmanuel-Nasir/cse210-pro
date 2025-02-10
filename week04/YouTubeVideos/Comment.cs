using System;
class Comment{
    private string nameOfCommenter;
    private string text;
    
    public Comment (string nameOfCommenter, string text){
        this.nameOfCommenter = nameOfCommenter;
        this.text = text;
    }
    public void DisplayComment(){
        Console.WriteLine($"-{nameOfCommenter}:{text}");
    }
}