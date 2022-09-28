namespace HouseholdAppliances;

public class ElectricStove : Appliance, ICooker
{
    public int BoilingTime { get; set; }
    public int MaximumTemperature { get; set; }

    public ElectricStove(string brand, string model, int boilingTime, int maximumTemperature, bool isOn = false) : base(brand, model, isOn)
    {
        BoilingTime = boilingTime;
        MaximumTemperature = maximumTemperature;
    }

    public void Cook(string food)
    {
        if (!IsOn) throw new Exception("The stove is not turned on");
            Console.WriteLine($"Cooking {food} on {Brand} {Model} for {BoilingTime} minutes at {MaximumTemperature} degrees.");
    }

    public void Bake(string food)
    {
        if (!IsOn) throw new Exception("The stove is not turned on");
            Console.WriteLine($"Baking {food} on {Brand} {Model} for {BoilingTime} minutes at {MaximumTemperature} degrees.");
    }
}