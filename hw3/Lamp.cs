namespace hw3;

public class Lamp : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("Lamp is off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("Lamp is on");
    }

}
