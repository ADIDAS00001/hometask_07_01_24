namespace hw1;

public class Teacher : Person
{
    public override void Greet()
    {
        base.Greet();
    }
    public void Explain()
    {
        System.Console.WriteLine("I'm explaining");
    }
}
