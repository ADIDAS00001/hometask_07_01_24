namespace hw2;

public class Circle : Shape
{
    double _radius;
    public Circle(double radius,string color)
    :base(color)
    {
        _radius=radius;
    }
}
