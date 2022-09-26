namespace Geometry.Test;

public class ParallelepipedTest
{
    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 5)]
    [Theory]
    public void TestParallelepiped(double height, double width, double depth)
    {
        var parallelepiped = new Parallelepiped(width, height, depth);
        parallelepiped.Height.Should().Be(height);
        parallelepiped.Width.Should().Be(width);
        parallelepiped.Depth.Should().Be(depth);
        parallelepiped.Volume.Should().Be(height * width * depth);
        parallelepiped.SurfaceArea.Should().Be(2 * (height * width + height * depth + width * depth));
    }
}