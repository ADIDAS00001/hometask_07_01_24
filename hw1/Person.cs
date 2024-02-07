namespace hw1;

public class Person
{
    public int Age { get; set; } 
    public virtual void  Greet()
    {
        System.Console.WriteLine( "Hello!");
    }
    public void SetAge(int age)
    {
        Age=age;
    }
}
