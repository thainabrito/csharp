namespace Geometry;
public class Cube : Parallelepiped
{
    public readonly double Side;
    public new Square FaceA => new(Side);
    public new Square FaceB => new(Side);
    public new Square FaceC => new(Side);
    public Cube(double side) : base(side, side, side)
    {
        Side = side;
    }
}