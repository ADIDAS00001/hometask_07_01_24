namespace hw3;

public class Lock : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("Lock is off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("Lock is on");
    }
}
