using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

       Video video1 = new Video(" Angels Like You ", "Miley Cyrus", 245);
        video1.AddComment("Maria Lopez", "It's my favorite song");
        video1.AddComment("Claudia Ruiz", "I love Miley Cyrus!!");
        video1.AddComment("Ann Gomez", "This song hit me unexpectedly.");
        videos.Add(video1);

        Video video2 = new Video("C++ Object-Oriented Programming", "Laura Sanchez", 850);
        video2.AddComment("Parker Torres", "Great content.");
        video2.AddComment("Sophie Mamani", "Now I understand better.");
        video2.AddComment("Ariane Arias", "Very clear.");
        videos.Add(video2);

        Video video3 = new Video("How I Learned to Code in 4 Months & Got a Job!", "Tim Kim", 360);
        video3.AddComment("Lucia Fernandez", "This is exactly what I needed.");
        video3.AddComment("Miguel Castillo", "Super interesting!");
        video3.AddComment("Richard Perez", "I loved the explanation.");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}