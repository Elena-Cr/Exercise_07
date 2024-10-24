namespace exercise_07;
public class Processor
{
    public void Process()
    {
        Car c = new();
        Motorcycle m = new();
        Truck t = new();

        c.Drive();
        c.StartEngine();
        c.StopEngine();

        m.Ride();
        m.StartEngine();
        m.StopEngine();

        t.LoadCargo();
        t.StartEngine();
        t.StopEngine();

    }

}