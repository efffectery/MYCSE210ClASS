using System;

class Video
{
    public string title;
    public string author;
    public int length;
    public List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length, List<Comment> comments)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = comments;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Length: {length}");
        foreach(Comment comment in comments)
        {
            Console.WriteLine(comment.DisplayComment());
            Console.WriteLine();
        }
    }

}