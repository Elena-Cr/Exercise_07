namespace exercise_07;

public class Vehicle
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine Started");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine Stopped");
    }
}