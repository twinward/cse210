using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        comments.Add(new Comment(commenterName, text));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayComments()
    {
        foreach (var comment in comments)
        {
            Console.WriteLine($"\tComment by {comment.CommenterName}: {comment.Text}");
        }
    }
}