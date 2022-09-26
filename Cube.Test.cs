namespace Geometry.Test;

public class CubeTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestCube(double side)
    {
        var cube = new Cube(side);
        cube.Side.Should().Be(side);
        cube.FaceA.Should().BeOfType<Square>();
        cube.FaceA.Area.Should().Be(side * side);
        cube.FaceB.Should().BeOfType<Square>();
        cube.FaceB.Area.Should().Be(side * side);
        cube.FaceC.Should().BeOfType<Square>();
        cube.FaceC.Area.Should().Be(side * side);
        cube.Volume.Should().Be(side * side * side);
    }
}