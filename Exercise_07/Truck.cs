namespace exercise_07;
public class Truck : Vehicle
{
    public int? LoadCapacity { get; set; }
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo");
    }
}