namespace HouseholdAppliances;

public class Microwave : Appliance, ICooker
{
    public int BoilingTime { get; set; }
    public int MaximumTemperature { get; set; }

    public Microwave(string brand, string model, int boilingTime, int maximumTemperature, bool isOn = false) : base(brand, model, isOn)
    {
        BoilingTime = boilingTime;
        MaximumTemperature = maximumTemperature;
    }

    public void Cook(string food)
    {
        if (!IsOn) throw new Exception("The stove is not turned on");
            Console.WriteLine($"Cooking {food} on {Brand} {Model} for {BoilingTime} minutes at {MaximumTemperature} degrees.");
    }

        public void Heat (string food)
    {
        if (!IsOn) throw new Exception("The stove is not turned on");
            Console.WriteLine($"Heating {food} on {Brand} {Model} for {BoilingTime} minutes at {MaximumTemperature} degrees.");
    }
}