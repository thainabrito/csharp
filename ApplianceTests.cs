namespace HouseholdAppliances.Test;

public class ApplianceTests
{
    public static TheoryData<object, object> PolymorphismData => new TheoryData<object, object>
    {
        {
            new Microwave("Samsung", "MW-01", 5, 100),
            new ElectricStove("Electrolux", "ST-02", 10, 200)
        },
    };

    [Theory]
    [InlineData("Samsung", "ST-01", 5, 100, false)]
    [InlineData("Electrolux", "ST-02", 10, 200, false)]
    public void TestMicrowave(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var microwave = new Microwave(brand, model, boilingTime, maximumTemperature, initialIsOn);
        microwave.IsOn.Should().BeFalse();
        microwave.Model.Should().Be(model);
        microwave.Brand.Should().Be(brand);
        microwave.BoilingTime.Should().Be(boilingTime);
        microwave.MaximumTemperature.Should().Be(maximumTemperature);

        var cookFailure  = () => microwave.Cook("Food");
        cookFailure.Should().Throw<Exception>().WithMessage("The stove is not turned on");

        microwave.SwitchPower();
        microwave.IsOn.Should().BeTrue();

        var cookSuccess = () => microwave.Cook("Cake");
        cookSuccess.Should().NotThrow();

        microwave.SwitchPower();
        microwave.IsOn.Should().BeFalse();

        var heatFailure = () => microwave.Heat("Cake");
        heatFailure.Should().Throw<Exception>().WithMessage("The stove is not turned on");

        microwave.SwitchPower();

        var heatSuccess = () => microwave.Heat("Cake");
        heatSuccess.Should().NotThrow();
    }

    [Theory]
    [InlineData("Samsung", "MW-01", 5, 100, false)]
    [InlineData("Electrolux", "MW-02", 10, 200, false)]
    public void TestElectricStove(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var electricStove = new ElectricStove(brand, model, boilingTime, maximumTemperature, initialIsOn);
        electricStove.IsOn.Should().BeFalse();
        electricStove.Model.Should().Be(model);
        electricStove.Brand.Should().Be(brand);
        electricStove.BoilingTime.Should().Be(boilingTime);
        electricStove.MaximumTemperature.Should().Be(maximumTemperature);

        var cookFailure = () => electricStove.Cook("food");
        cookFailure.Should().Throw<Exception>().WithMessage("The stove is not turned on");

        electricStove.SwitchPower();
        electricStove.IsOn.Should().BeTrue();

        var cookSuccess = () => electricStove.Cook("food");
        cookSuccess.Should().NotThrow();

        electricStove.SwitchPower();
        electricStove.IsOn.Should().BeFalse();

        var bakeFailure = () => electricStove.Bake("food");
        bakeFailure.Should().Throw<Exception>().WithMessage("The stove is not turned on");

        electricStove.SwitchPower();

        var bakeAction = () => electricStove.Bake("food");
        bakeAction.Should().NotThrow();
    }

    [Theory]
    [MemberData(nameof(PolymorphismData))]
    public void TestPolymorphism(object microwave, object electricStove)
    {
        microwave.Should().BeAssignableTo<ICooker>();
        microwave.Should().BeAssignableTo<Appliance>();
        electricStove.Should().BeAssignableTo<ICooker>();
        electricStove.Should().BeAssignableTo<Appliance>();
    }
}