namespace hw3;

public class Thermostat : IDevice
{
       public void TurnOff()
    {
        System.Console.WriteLine("Thermostat is off");
    }
    public void TurnOn()
    {
        System.Console.WriteLine("Thermostat is on");
    }
}
