namespace Geometry;
public class Rectangle
{
    public readonly double Width;
    public readonly double Height;

    public double Area => Width * Height;

    public double Perimeter => 2 * (Width + Height);

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException("All sides must be greater than zero");
        }
        Width = width;
        Height = height;
    }
}