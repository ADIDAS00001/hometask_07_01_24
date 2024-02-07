namespace hw1;

public class Student : Person
{
    public override void Greet()
    {
        System.Console.WriteLine("Hello!");
    }
    public void ShowAge()
    {
        System.Console.WriteLine($"My age is: {Age} years old");
    }
    public void Study()
    {
        System.Console.WriteLine("I'm studying");
    }


}
