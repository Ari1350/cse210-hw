using System;

class Video{
    public string Title { get; set; }
    public string Person { get; set; }
    public int Duration { get; set; } 
    private List<Comment> comments;

    public Video(string title, string person, int duration)
    {
        Title = title;
        Person = person;
        Duration = duration;
        comments = new List<Comment>();
    }

    public void AddComment(string person, string text)
    {
        comments.Add(new Comment(person, text));
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Person}\nDuration: {Duration} seconds\nComments: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.Person}: {comment.Text}");
        }
        Console.WriteLine();
    }
}