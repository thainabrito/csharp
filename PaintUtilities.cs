namespace PaintShop.Test;

public static class PaintUtilities
{
    public static int BucketSizeLiters { get; set; } = 20;
    public static int SquareMetersPerLiter { get; set; } = 10; 

    public static int SquareMetersPerBucket
    {
        get { return BucketSizeLiters * SquareMetersPerLiter;}
    }
    public static int GetNeededPaintBuckets(double areaToBePainted)
    {
        var qty = areaToBePainted / SquareMetersPerBucket;
        return Convert.ToInt32(Math.Ceiling(qty));
    }

    public static int GetNeededPaintBuckets(Wall wallToBePainted)
    {
        var qty = wallToBePainted.PaintableArea / SquareMetersPerBucket;
        return Convert.ToInt32(Math.Ceiling(qty));
    }

    public static int GetNeededPaintBuckets(Room roomToBePainted)
    {
        var qty = roomToBePainted.TotalPaintableArea / SquareMetersPerBucket;
        return Convert.ToInt32(Math.Ceiling(qty));
    }

    public static decimal CalculateCost(decimal price, double area)
    {
        var result = GetNeededPaintBuckets(area) * price;
        return result;
    }

    public static decimal CalculateCost(decimal price, Wall parede)
    {
        var result = GetNeededPaintBuckets(parede.PaintableArea) * price;
        return result;
    }

    public static decimal CalculateCost(decimal price, Room comodo)
    {
        var result = GetNeededPaintBuckets(comodo.TotalPaintableArea) * price;
        return result;
    }
}