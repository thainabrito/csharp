namespace PaintShop;

public class Room
{
    public Wall[] Walls {get;}
    public double TotalPaintableArea { get; set;}
    public Room(params Wall[] walls)
    {
        Walls = walls;
        foreach(var wall in Walls)
        {
            TotalPaintableArea += wall.PaintableArea;
        }
    }
}