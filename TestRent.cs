using Xunit;
using FluentAssertions;
using RentCars.Models;
using RentCars.Types;
using System;
using System.Collections.Generic;

namespace RentCars.Test;

public class TestRent
{
    public static IEnumerable<object[]> RentTestData()
    {
        yield return new object[] {new Car()
            {
                Brand = "Ford",
                Model = "Mustang",
                Year = 2019,
                MainColor = new Color() { Name = "Preto", Hex = "#000000" },
                Seats = 5,
                Doors = 5,
                Traction = TractionType.RearWheelDrive,
                FrontBrake = BrakeType.Chamber,
                RearBrake = BrakeType.Chamber,
                PricePerDay = 70.0
            }, 
            new PhysicalPerson()
            {
                Name = "joãozinho",
                Email = "joao@gmail.com",
                Address = "Rua antonio olinda, 204",
                Contact = "88 999554454",
                CPF = "011.787.456-65"
            },
            10,
            700.0};
        
    }

    [Theory(DisplayName = "Deve cadastrar contas com sucesso!")]
    [MemberData(nameof(RentTestData))]
    public void TestCreateRent(Vehicle vehicle, Person person, int daysRented, double expectedPrice)
    {
        var rent = new Rent(vehicle, person, daysRented);

        rent.Vehicle.Should().Be(vehicle);
        rent.Person.Should().Be(person);
        rent.DaysRented.Should().Be(daysRented);
        rent.Price.Should().Be(expectedPrice);
        rent.Status.Should().Be(RentStatus.Confirmed);
    }
}
