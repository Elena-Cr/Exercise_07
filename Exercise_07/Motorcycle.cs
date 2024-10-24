namespace exercise_07;
public class Motorcycle : Vehicle
{
    public string? Type { get; set; }

    public void Ride()
    {
        Console.WriteLine("Riding a motorcycle");
    }
}