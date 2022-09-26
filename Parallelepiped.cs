namespace Geometry;
public class Parallelepiped
{
    public readonly double Width;
    public readonly double Height;
    public readonly double Depth;

    public Rectangle FaceA => new(Width, Height);
    public Rectangle FaceB => new(Height, Depth);
    public Rectangle FaceC => new(Width, Depth);

    public double SurfaceArea => 2 * (FaceA.Area + FaceB.Area + FaceC.Area);

    public double Volume => Width * Height * Depth;
    public Parallelepiped(double width, double height, double depth)
    {
        if (width <= 0 || height <= 0 || depth <= 0) {
        throw new ArgumentException("All sides must be greater than zero");
        }
        Width = width;
        Height = height;
        Depth = depth;
    }
}
