namespace HouseholdAppliances;

public interface ICooker
{
    int BoilingTime { get; set; }
    int MaximumTemperature { get; set; }

    public void Cook(string food);
}
