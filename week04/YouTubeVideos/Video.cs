using System;

class Video{
    public string _Title { get; set; }
    public string _Person { get; set; }
    public int _Duration { get; set; } 
    private List<Comment> _comments;

    public Video(string title, string person, int duration)
    {
        _Title = title;
        _Person = person;
        _Duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(string person, string text)
    {
        _comments.Add(new Comment(person, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_Title}\nAuthor: {_Person}\nDuration: {_Duration} seconds\nComments: {GetCommentCount()}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._Person}: {comment._Text}");
        }
        Console.WriteLine();
    }
}