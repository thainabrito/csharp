namespace HouseholdAppliances;

public abstract class Appliance
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public bool IsOn { get; private set; }
    public void SwitchPower() => IsOn = !IsOn;

    public Appliance(string brand, string model, bool isOn)
    {
        Brand = brand;
        Model = model;
        IsOn = isOn;
    }
}