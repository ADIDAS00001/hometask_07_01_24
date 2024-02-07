namespace hw2;

public class Restangle : Shape
{
    double _length;
    double _width;
    public Restangle(double length,double width,string color)
    :base(color)
    {
        _length=length;
       _width=width;
    }
}
