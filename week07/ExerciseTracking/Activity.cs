public abstract class Activity
{
    private DateTime date;
    private int duration; 

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} ({Duration} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} km/h, Pace: {GetPace():0.00} min per km";
    }
}
