using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2005;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Amazon";
        job2._startYear = 2020;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        
        myResume._name = "Guadalupe Arias";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}