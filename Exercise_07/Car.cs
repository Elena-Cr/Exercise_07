namespace exercise_07;

public class Car : Vehicle
{
    public int? NumberOfDoors { get; set; }

    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}